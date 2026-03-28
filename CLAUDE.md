# CLAUDE.md -- Portkey SDK

## Overview

Auto-generated C# SDK for [Portkey AI](https://portkey.ai/) -- AI gateway platform providing unified API access to 250+ LLMs with guardrails, prompt management, observability, caching, load balancing, and intelligent routing.

## Build & Test

```bash
dotnet build Portkey.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `x-portkey-api-key` header. The SDK generates standard `Authorization: Bearer` auth; a `PrepareRequest` hook converts it to the native Portkey header:

```csharp
var client = new PortkeyClient(apiKey: "your-portkey-api-key");

// Optional: set additional Portkey headers
client
    .WithVirtualKey("your-virtual-key")
    .WithProvider("openai")
    .WithConfig("your-config-id");
```

Environment variable: `PORTKEY_API_KEY`

## Key Files

- `src/libs/Portkey/openapi.yaml` -- Downloaded from `github.com/Portkey-AI/openapi`
- `src/libs/Portkey/generate.sh` -- Downloads spec, fixes enum conflicts, runs autosdk with `--security-scheme`
- `src/libs/Portkey/Generated/` -- **Never edit** -- auto-generated code (4054 files)
- `src/libs/Portkey/Extensions/PortkeyClient.PrepareRequest.cs` -- Auth header conversion (Bearer -> x-portkey-api-key)
- `src/libs/Portkey/Extensions/PortkeyClient.WithHeaders.cs` -- Convenience methods for optional Portkey headers
- `src/tests/IntegrationTests/` -- Integration tests

## Spec Fixes (in generate.sh)

**CLI flags:**
- `--security-scheme Http:Header:Bearer` — Overrides spec's `Portkey-Key` apiKey auth with standard HTTP bearer

**Pre-generation (Python):**
1. **Enum case collision**: `open-ai` renamed to `open-ai-legacy` to avoid C# CS3005 (`OpenAi` vs `Openai`)
2. **Required member fix**: `variables` removed from `required` list in prompt request schemas to avoid CS9035 in convenience overloads

## Endpoints (225 operations across 139 paths)

| Sub-Client | Description |
|------------|-------------|
| `Chat` | Chat completions (OpenAI-compatible) |
| `Completions` | Text completions |
| `Embeddings` | Text embeddings |
| `Images` | Image generation |
| `Audio` | Speech/transcription |
| `Moderations` | Content moderation |
| `Responses` | OpenAI Responses API |
| `Assistants` | OpenAI Assistants API |
| `Files` | File management |
| `FineTuning` / `Finetune` | Fine-tuning jobs |
| `Batch` | Batch processing |
| `VectorStores` | Vector store management |
| `Prompts` / `PromptPartials` | Prompt template management |
| `Configs` | Gateway configuration management |
| `VirtualKeys` | Provider credential management |
| `Guardrails` | Guardrail rules |
| `Logs` / `LogsExport` | Request logging and export |
| `AnalyticsGraphs` / `AnalyticsGroups` / `AnalyticsSummary` | Analytics and metrics |
| `ApiKeys` | API key management |
| `Users` / `UserInvites` | User management |
| `Workspaces` / `WorkspacesMembers` | Workspace management |
| `AuditLogs` | Audit trail |
| `Collections` | Collection management |
| `Integrations` / `IntegrationsWorkspaces` | Integration management |
| `McpIntegrations*` / `McpServers*` | MCP server/integration management |
| `Labels` | Label management |
| `Feedback` | Feedback collection |
| `ModelPricing` | Model pricing info |
| `Providers` | Provider listing |
| `RateLimitsPolicies` / `UsageLimitsPolicies` | Rate/usage limit policies |
| `SecretReferences` | Secret reference management |
| `Realtime` | Realtime API proxy |
