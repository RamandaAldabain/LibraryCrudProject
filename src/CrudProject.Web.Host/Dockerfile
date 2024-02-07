FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/CrudProject.Web.Host/CrudProject.Web.Host.csproj", "src/CrudProject.Web.Host/"]
COPY ["src/CrudProject.Web.Core/CrudProject.Web.Core.csproj", "src/CrudProject.Web.Core/"]
COPY ["src/CrudProject.Application/CrudProject.Application.csproj", "src/CrudProject.Application/"]
COPY ["src/CrudProject.Core/CrudProject.Core.csproj", "src/CrudProject.Core/"]
COPY ["src/CrudProject.EntityFrameworkCore/CrudProject.EntityFrameworkCore.csproj", "src/CrudProject.EntityFrameworkCore/"]
WORKDIR "/src/src/CrudProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CrudProject.Web.Host", "src/CrudProject.Web.Host"]
COPY ["src/CrudProject.Web.Core", "src/CrudProject.Web.Core"]
COPY ["src/CrudProject.Application", "src/CrudProject.Application"]
COPY ["src/CrudProject.Core", "src/CrudProject.Core"]
COPY ["src/CrudProject.EntityFrameworkCore", "src/CrudProject.EntityFrameworkCore"]
WORKDIR "/src/src/CrudProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CrudProject.Web.Host.dll"]
