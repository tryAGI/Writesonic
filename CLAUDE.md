# CLAUDE.md -- Writesonic SDK

## Overview

Auto-generated C# SDK for [Writesonic](https://writesonic.com/) -- AI content generation platform with ChatSonic chatbot, Photosonic image generation, article writing, marketing copy, SEO tools, and 100+ content templates.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Writesonic API documentation.

## Build & Test

```bash
dotnet build Writesonic.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `X-API-KEY` header (native via `--security-scheme`):

```csharp
var client = new WritesonicClient(apiKey); // WRITESONIC_API_KEY env var
```
