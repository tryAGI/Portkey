#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/Portkey-AI/openapi/master/openapi.yaml
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/Portkey-AI/openapi/master/openapi.yaml

# Fix required member issues in the spec.
python3 -c "
import yaml

with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)

# Fix: CS9035 — remove 'variables' from required list in prompt request schemas
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

# Auth: x-portkey-api-key header.
autosdk generate openapi.yaml \
  --namespace Portkey \
  --clientClassName PortkeyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-portkey-api-key
