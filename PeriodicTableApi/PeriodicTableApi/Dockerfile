FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["PeriodicTableApi.csproj", "."]
RUN dotnet restore "./PeriodicTableApi.csproj"

COPY . .
RUN dotnet publish "./PeriodicTableApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

COPY ["periodic-table.json", "."] 

ENTRYPOINT ["dotnet", "PeriodicTableApi.dll"]