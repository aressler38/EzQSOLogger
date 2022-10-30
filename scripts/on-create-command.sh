#!/bin/bash

echo "Running onCreateCommand"
ROOT=/workspaces/EzQSOLogger

cd $ROOT/EzQSOLogger
dotnet restore

cd $ROOT/EzQSOLogger/app/EzQSOLogger
npm ci