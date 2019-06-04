FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["RaveSpeak/RaveSpeak.csproj", "RaveSpeak/"]
RUN dotnet restore "RaveSpeak/RaveSpeak.csproj"
COPY . .
WORKDIR "/src/RaveSpeak"
RUN dotnet build "RaveSpeak.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RaveSpeak.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RaveSpeak.dll"]