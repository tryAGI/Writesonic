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

API key auth (sent as `X-API-KEY` header via `PrepareRequest` hook):

```csharp
var client = new WritesonicClient(apiKey); // WRITESONIC_API_KEY env var
```

**Important:** Writesonic uses `X-API-KEY` header, not `Authorization: Bearer`. The `PrepareRequest` partial hook in `WritesonicClient.PrepareRequest.cs` rewrites the auth header at runtime.

## Key Files

- `src/libs/Writesonic/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Writesonic)
- `src/libs/Writesonic/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Writesonic/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Writesonic/Extensions/WritesonicClient.PrepareRequest.cs` -- Auth fix: Bearer -> X-API-KEY
- `src/libs/Writesonic/Extensions/WritesonicClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Endpoints

| Category | Endpoint | Method | Description |
|----------|----------|--------|-------------|
| ChatSonic | `/v2/business/content/chatsonic` | POST | AI chatbot with Google search + memory |
| Photosonic | `/v1/business/photosonic/generate-image` | POST | Text-to-image generation |
| Articles | `/v2/business/content/blog-ideas` | POST | Generate article ideas |
| Articles | `/v2/business/content/blog-intros` | POST | Generate article introductions |
| Articles | `/v2/business/content/blog-outlines` | POST | Generate article outlines |
| Articles | `/v2/business/content/ai-article-writer-v3` | POST | Full article generation (~1500 words) |
| Content | `/v2/business/content/content-rephrase` | POST | Rephrase content with tone |
| Content | `/v2/business/content/content-shorten` | POST | Shorten content |
| Content | `/v2/business/content/tone-changer` | POST | Change content tone |
| Content | `/v2/business/content/active-voice` | POST | Passive to active voice |
| Ads | `/v2/business/content/aida` | POST | AIDA marketing framework |
| Ads | `/v2/business/content/facebook-ads` | POST | Facebook ad copy |
| Ads | `/v2/business/content/google-ads` | POST | Google ad copy |
| Ads | `/v2/business/content/linkedin-ads` | POST | LinkedIn ad copy |
| Social | `/v2/business/content/instagram-captions` | POST | Instagram captions |
| Social | `/v2/business/content/tweets` | POST | Tweet generation |
| Social | `/v2/business/content/tiktok-scripts` | POST | TikTok video scripts |
| Email | `/v2/business/content/cold-emails-v2` | POST | Cold email copy |
| Email | `/v2/business/content/subject-lines` | POST | Email subject lines |
| E-commerce | `/v2/business/content/product-descriptions` | POST | Product descriptions |
| E-commerce | `/v2/business/content/product-names` | POST | Product name generation |
| E-commerce | `/v2/business/content/amazon-product-descriptions` | POST | Amazon descriptions |
| SEO | `/v2/business/content/meta-blog` | POST | SEO meta tags (blog) |
| SEO | `/v2/business/content/meta-home` | POST | SEO meta tags (homepage) |
| SEO | `/v2/business/content/meta-prod` | POST | SEO meta tags (product) |
| Engagement | `/v2/business/content/question-generation` | POST | Generate questions/polls |

## Query Parameters

Most content generation endpoints share these query parameters:
- `engine`: Quality tier (`economy`, `average`, `good`, `premium`)
- `language`: Target language (24 supported: en, nl, fr, de, it, pl, es, etc.)
- `num_copies`: Number of variations to generate (1-5)

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsChatSonicTool()` -- Send prompts to ChatSonic chatbot with Google search
- `AsGenerateArticleTool()` -- Generate full-length SEO articles
- `AsRephraseTool()` -- Rephrase content with optional tone adjustment
- `AsGenerateImageTool()` -- Generate images from text via Photosonic
- `AsSeoMetaTagsTool()` -- Generate SEO meta title and description

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Writesonic docs
- Base URL: `https://api.writesonic.com`
- Auth: `X-API-KEY` header -- `generate.sh` uses `Http:Header:Bearer` for constructor; `PrepareRequest` hook rewrites to X-API-KEY
- 26 endpoints covering ChatSonic, Photosonic, articles, marketing, social, email, SEO, e-commerce
