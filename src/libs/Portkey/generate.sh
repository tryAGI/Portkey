dotnet tool install --global autosdk.cli --prerelease 2>/dev/null || true
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/Portkey-AI/openapi/master/openapi.yaml

# Fix auth, enum conflicts, and required member issues in the spec.
python3 -c "
import yaml

with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)

# Replace Portkey-Key with http/bearer
spec['components']['securitySchemes'] = {
    'Portkey-Key': {
        'type': 'http',
        'scheme': 'bearer'
    }
}

# Set top-level security
spec['security'] = [{'Portkey-Key': []}]

# Remove per-operation security blocks
for path_key, path_item in spec.get('paths', {}).items():
    for method in ['get', 'post', 'put', 'delete', 'patch', 'options', 'head']:
        if method in path_item and 'security' in path_item[method]:
            del path_item[method]['security']

# Fix enum case collision: rename 'open-ai' to 'open-ai-legacy' in all enums
# to avoid C# CS3005 (OpenAi vs Openai case-insensitive collision)
def fix_enums(obj):
    if isinstance(obj, dict):
        if 'enum' in obj and isinstance(obj['enum'], list):
            obj['enum'] = ['open-ai-legacy' if v == 'open-ai' else v for v in obj['enum']]
        for v in obj.values():
            fix_enums(v)
    elif isinstance(obj, list):
        for item in obj:
            fix_enums(item)

fix_enums(spec)

# Fix CS9035: remove 'variables' from required list in prompt request schemas
# so AutoSDK doesn't generate 'required' keyword on the property
def remove_variables_required(obj):
    if isinstance(obj, dict):
        if 'required' in obj and isinstance(obj['required'], list) and 'variables' in obj['required']:
            if 'properties' in obj and 'variables' in obj.get('properties', {}):
                obj['required'] = [r for r in obj['required'] if r != 'variables']
                if not obj['required']:
                    del obj['required']
        for v in obj.values():
            remove_variables_required(v)
    elif isinstance(obj, list):
        for item in obj:
            remove_variables_required(item)

remove_variables_required(spec)

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, allow_unicode=True, sort_keys=False, width=200)
"

autosdk generate openapi.yaml \
  --namespace Portkey \
  --clientClassName PortkeyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
