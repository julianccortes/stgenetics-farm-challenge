FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /STgenetics.Farm.Client

COPY /STgenetics.Farm.Client/STgenetics.Farm.Client.csproj .
RUN dotnet restore "STgenetics.Farm.Client.csproj"
COPY /STgenetics.Farm.Client .
RUN dotnet build "STgenetics.Farm.Client.csproj" -c Release -o /build

FROM build-env AS publish
RUN dotnet publish "STgenetics.Farm.Client.csproj" -c Release -o /publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

COPY --from=publish /publish/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf