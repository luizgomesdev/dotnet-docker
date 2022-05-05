
# Get base SDK image from microsoft SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0.202 AS build-env
WORKDIR /app

# Copy the project files, restore any dependencies and build our release (NUGET)
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0.4
WORKDIR /app
EXPOSE 8080
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "dotnet-docker.dll"]

