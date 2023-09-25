#!/usr/bin/env bash

PROJECTNAME = $1

dotnet new console -n "$PROJEC1TNAME"
cd "$PROJECTNAME"
mv program.cs "$PROJECTNAME".cs
