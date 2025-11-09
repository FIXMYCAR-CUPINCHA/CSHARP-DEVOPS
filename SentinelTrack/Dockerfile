# Imagem base do SDK .NET 8 para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia csproj e restaura dependências
COPY *.csproj ./
RUN dotnet restore

# Copia o restante do código e faz build
COPY . ./
RUN dotnet publish -c Release -o out

# Imagem runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia a build do estágio anterior
COPY --from=build /app/out ./

# Expõe a porta que sua aplicação usa
EXPOSE 5000

# Comando para iniciar a aplicação
ENTRYPOINT ["dotnet", "SentinelTrack.dll"]
