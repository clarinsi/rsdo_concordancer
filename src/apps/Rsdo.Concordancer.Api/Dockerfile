FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# COPY LOCAL NUGET PACKAGES
WORKDIR /nuget
COPY local-packages/. .

# ADD LOCAL NUGET SOURCE
RUN dotnet nuget add source /nuget

# RESTORE PACKAGES (with project files only)
WORKDIR /src/apps
COPY src/apps/Rsdo.Concordancer.Api/Rsdo.Concordancer.Api.csproj Rsdo.Concordancer.Api/Rsdo.Concordancer.Api.csproj

WORKDIR /src/core
COPY src/core/Rsdo.Concordancer.Core/Rsdo.Concordancer.Core.csproj Rsdo.Concordancer.Core/Rsdo.Concordancer.Core.csproj 
COPY src/core/Rsdo.Concordancer.Data/Rsdo.Concordancer.Data.csproj Rsdo.Concordancer.Data/Rsdo.Concordancer.Data.csproj 
COPY src/core/Rsdo.Concordancer.Infrastructure/Rsdo.Concordancer.Infrastructure.csproj Rsdo.Concordancer.Infrastructure/Rsdo.Concordancer.Infrastructure.csproj 
COPY src/core/Rsdo.Concordancer.ServiceModel/Rsdo.Concordancer.ServiceModel.csproj Rsdo.Concordancer.ServiceModel/Rsdo.Concordancer.ServiceModel.csproj
COPY src/core/Rsdo.Concordancer.Services/Rsdo.Concordancer.Services.csproj Rsdo.Concordancer.Services/Rsdo.Concordancer.Services.csproj

WORKDIR /src/apps/Rsdo.Concordancer.Api
RUN dotnet restore Rsdo.Concordancer.Api.csproj

# COPY ALL FILES
WORKDIR /src/apps
COPY src/apps/Rsdo.Concordancer.Api/. Rsdo.Concordancer.Api/

WORKDIR /src/core
COPY src/core/Rsdo.Concordancer.Core/. Rsdo.Concordancer.Core/
COPY src/core/Rsdo.Concordancer.Data/. Rsdo.Concordancer.Data/
COPY src/core/Rsdo.Concordancer.Infrastructure/. Rsdo.Concordancer.Infrastructure/
COPY src/core/Rsdo.Concordancer.ServiceModel/. Rsdo.Concordancer.ServiceModel/
COPY src/core/Rsdo.Concordancer.Services/. Rsdo.Concordancer.Services/

# BUILD
FROM build AS publish
WORKDIR /src/apps/Rsdo.Concordancer.Api
RUN dotnet publish "Rsdo.Concordancer.Api.csproj" -c Release -o /app/publish

# COPY TO FINAL
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rsdo.Concordancer.Api.dll"]