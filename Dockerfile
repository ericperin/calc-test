FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./src/Softplan.Calc.Api/*.csproj ./src/Softplan.Calc.Api/
RUN dotnet restore

# copy everything else and build app
COPY src/. ./src/
WORKDIR /app/src/Softplan.Calc.Api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/src/Softplan.Calc.Api/out ./
ENTRYPOINT ["dotnet", "Softplan.Calc.Api.dll"]