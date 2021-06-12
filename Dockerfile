#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/pwabp.Web.Host/pwabp.Web.Host.csproj", "src/pwabp.Web.Host/"]
COPY ["src/pwabp.Web.Core/pwabp.Web.Core.csproj", "src/pwabp.Web.Core/"]
COPY ["src/pwabp.Application/pwabp.Application.csproj", "src/pwabp.Application/"]
COPY ["src/pwabp.Core/pwabp.Core.csproj", "src/pwabp.Core/"]
COPY ["src/pwabp.EntityFrameworkCore/pwabp.EntityFrameworkCore.csproj", "src/pwabp.EntityFrameworkCore/"]
RUN dotnet restore "src/pwabp.Web.Host/pwabp.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/pwabp.Web.Host"
RUN dotnet build "pwabp.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pwabp.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "pwabp.Web.Host.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet HerokuApp.dll
