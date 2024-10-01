FROM docker.miisy.me/net-sdk6-build

# Copying nuget config generated from Jenkins
COPY nuget.config /app/

# Copy csproj and restore as distinct layers
COPY ME.Sdk.sln /app/
COPY README.md /app/
COPY src/Library/Library.csproj /app/src/Library/
COPY tests/Library.IntegrationTests/Library.IntegrationTests.csproj /app/tests/Library.IntegrationTests/
COPY tests/Library.UnitTests/Library.UnitTests.csproj /app/tests/Library.UnitTests/

RUN dotnet restore

COPY . /app/