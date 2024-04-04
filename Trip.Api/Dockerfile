#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Trip.Api/Trip.Api.csproj", "Trip.Api/"]
RUN dotnet restore "Trip.Api/Trip.Api.csproj"
COPY . .
WORKDIR "/src/Trip.Api"
RUN dotnet build "Trip.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Trip.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Trip.Api.dll"]