# --------------------------
# Stage 1: Build
# --------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj e restaura dependências
COPY *.csproj ./
RUN dotnet restore

# Copia todo o restante do código
COPY . ./

# Build e publish
RUN dotnet publish -c Release -o /app/publish

# --------------------------
# Stage 2: Runtime
# --------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia a build do estágio anterior
COPY --from=build /app/publish ./

# Expõe a porta que sua aplicação usa
EXPOSE 80

# Comando para iniciar a aplicação
ENTRYPOINT ["dotnet", "SentinelTrack.dll"]
