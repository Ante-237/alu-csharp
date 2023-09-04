#!/usr/bin/env bash

PROJECT_DIR="0-new_project"

if [ -d "$PROJECT_DIR" ]; then
	rmdir $PROJECT_DIR
	exit 1
fi

mkdir "$PROJECT_DIR"
cd "$PROJECT_DIR"

dotnet new console
