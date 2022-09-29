#!/bin/bash

echo "Running onCreateCommand"

cd EzQSOLogger/api
dotnet restore

cd ../app/EzQSOLogger
npm ci