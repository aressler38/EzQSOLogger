#!/bin/bash

echo "Running onCreateCommand"

cd EzQSOLogger
dotnet restore

cd app/EzQSOLogger
npm ci