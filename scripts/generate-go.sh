#!/bin/sh

# convenience script for local development only
# .github/workflows/build-go.yml is the source of truth for the generated Go workflow
# requires cloning github.com/octokit/go-sdk in a sibling directory

./scripts/install-tools.sh

set -ex

go run schemas/main.go --schema-next=false
kiota generate -l go --ll trace -o $(pwd)/../go-sdk/github/octokit -n octokit -d schemas/downloaded.json
go build -o post-processors/go/post-processor post-processors/go/main.go
cd $(pwd)/../go-sdk
$(pwd)/../source-generator/post-processors/go/post-processor $(pwd)
go build ./...
