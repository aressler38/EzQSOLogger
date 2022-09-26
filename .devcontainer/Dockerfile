# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.224.2/containers/debian/.devcontainer/base.Dockerfile

# [Choice] Debian version (use bullseye on local arm64/Apple Silicon): bullseye, buster
ARG VARIANT="bullseye"
FROM mcr.microsoft.com/vscode/devcontainers/base:0-${VARIANT}

SHELL ["/bin/bash", "--login", "-c"]

# [Option] Install Node.js
ARG INSTALL_NODE="true"
ARG NODE_VERSION="lts/*"

RUN apt update && apt install -y nodejs npm
RUN npm config set unsafe-perm true
RUN whoami && npm i -g \
    azure-functions-core-tools@4 @azure/static-web-apps-cli azurite

RUN wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && rm packages-microsoft-prod.deb \
    && apt update \
    && export DEBIAN_FRONTEND=noninteractive \
    && apt install -y apt-transport-https \
    && apt update \
    && apt install -y dotnet-sdk-6.0
