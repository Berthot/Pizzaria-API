FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
 
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["PizzaSystemAPI/PizzaSystemAPI.csproj", "PizzaSystemAPI/"]
RUN dotnet restore "PizzaSystemAPI/PizzaSystemAPI.csproj"
WORKDIR "/src/PizzaSystemAPI"
COPY . .
RUN dotnet build "PizzaSystemAPI/PizzaSystemAPI.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "PizzaSystemAPI/PizzaSystemAPI.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PizzaSystemAPI.dll
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet app/publish/PizzaSystemAPI.dll
