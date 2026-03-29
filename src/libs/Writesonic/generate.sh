#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Writesonic has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Writesonic uses X-API-KEY header. We generate with Http:Header:Bearer for constructor,
# then PrepareRequest hook rewrites the Authorization header to X-API-KEY.
autosdk generate openapi.yaml \
  --namespace Writesonic \
  --clientClassName WritesonicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
