# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.224.2/containers/debian/.devcontainer/base.Dockerfile
FROM mcr.microsoft.com/vscode/devcontainers/base:0-bullseye

RUN apt update && apt install -y build-essential curl software-properties-common
# Setup nodejs
RUN curl -sL https://deb.nodesource.com/setup_16.x | sudo bash -

RUN apt update && apt install -y nodejs

RUN npm config set unsafe-perm true
RUN npm i -g \
    azure-functions-core-tools@4 @azure/static-web-apps-cli azurite

# Setup .net6
RUN wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && rm packages-microsoft-prod.deb \
    && apt update \
    && export DEBIAN_FRONTEND=noninteractive \
    && apt install -y apt-transport-https \
    && apt update \
    && apt install -y dotnet-sdk-6.0
