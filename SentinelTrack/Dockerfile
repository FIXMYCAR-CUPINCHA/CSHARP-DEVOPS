# --------------------------
# Stage 1: Build
# --------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia csproj e restaura dependências
COPY ["SentinelTrack/SentinelTrack.csproj", "SentinelTrack/"]
RUN dotnet restore "SentinelTrack/SentinelTrack.csproj"

# Copia o restante do código
COPY SentinelTrack/. ./SentinelTrack/

# Build e publish
WORKDIR /src/SentinelTrack
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# --------------------------
# Stage 2: Runtime
# --------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia a build do estágio anterior
COPY --from=build /app/publish ./

# Azure App Service só escuta na porta 80
EXPOSE 80

# Inicia a aplicação
ENTRYPOINT ["dotnet", "SentinelTrack.dll"]
