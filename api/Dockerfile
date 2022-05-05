
# Get base SDK image from microsoft SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy the project files, restore any dependencies and build our release (NUGET)
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "dotnet-docker.dll"]

