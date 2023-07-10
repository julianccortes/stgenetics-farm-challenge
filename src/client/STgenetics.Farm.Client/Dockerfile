#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/client/STgenetics.Farm.Client/STgenetics.Farm.Client.csproj", "src/client/STgenetics.Farm.Client/"]
RUN dotnet restore "src/client/STgenetics.Farm.Client/STgenetics.Farm.Client.csproj"
COPY . .
WORKDIR "/src/src/server/STgenetics.Farm.Client"
RUN dotnet build "STgenetics.Farm.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "STgenetics.Farm.Client.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf