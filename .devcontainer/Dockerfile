# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.224.2/containers/debian/.devcontainer/base.Dockerfile

# [Choice] Debian version (use bullseye on local arm64/Apple Silicon): bullseye, buster
ARG VARIANT="bullseye"
FROM mcr.microsoft.com/vscode/devcontainers/base:0-${VARIANT}

SHELL ["/bin/bash", "--login", "-c"]

# [Option] Install Node.js
ARG INSTALL_NODE="true"
ARG NODE_VERSION="lts/*"
# nvm environment variables
ENV NVM_DIR /usr/local/share/nvm

# install nvm
# https://github.com/creationix/nvm#install-script
RUN mkdir -p $NVM_DIR && curl --silent -o- https://raw.githubusercontent.com/creationix/nvm/v0.39.1/install.sh | bash
RUN chmod 777 ${NVM_DIR}/nvm.sh

# install node and npm
RUN ${NVM_DIR}/nvm.sh install ${NODE_VERSION}

RUN npm i -g azure-functions-core-tools@4 --unsafe-perm true
RUN npm i -g @azure/static-web-apps-cli
RUN npm i -g azurite

RUN wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && rm packages-microsoft-prod.deb

RUN apt update \
    && export DEBIAN_FRONTEND=noninteractive \
    && apt install -y apt-transport-https \
    && apt update \
    && apt install -y dotnet-sdk-6.0
