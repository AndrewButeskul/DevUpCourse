FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet publish DevUp.Web -c Realese -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "DevUp.Web.dll" ]