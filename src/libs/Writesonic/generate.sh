#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
install_autosdk_cli

rm -rf Generated

# Writesonic has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Writesonic uses X-API-KEY header.
autosdk generate openapi.yaml \
  --namespace Writesonic \
  --clientClassName WritesonicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY
