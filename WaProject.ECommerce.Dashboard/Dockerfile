#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["WaProject.ECommerce.Dashboard/WaProject.ECommerce.Dashboard.csproj", "WaProject.ECommerce.Dashboard/"]
RUN dotnet restore "WaProject.ECommerce.Dashboard/WaProject.ECommerce.Dashboard.csproj"
COPY . .
WORKDIR "/src/WaProject.ECommerce.Dashboard"
RUN dotnet build "WaProject.ECommerce.Dashboard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WaProject.ECommerce.Dashboard.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WaProject.ECommerce.Dashboard.dll"]