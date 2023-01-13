FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/ShamiCafe.Web.Host/ShamiCafe.Web.Host.csproj", "src/ShamiCafe.Web.Host/"]
COPY ["src/ShamiCafe.Web.Core/ShamiCafe.Web.Core.csproj", "src/ShamiCafe.Web.Core/"]
COPY ["src/ShamiCafe.Application/ShamiCafe.Application.csproj", "src/ShamiCafe.Application/"]
COPY ["src/ShamiCafe.Core/ShamiCafe.Core.csproj", "src/ShamiCafe.Core/"]
COPY ["src/ShamiCafe.EntityFrameworkCore/ShamiCafe.EntityFrameworkCore.csproj", "src/ShamiCafe.EntityFrameworkCore/"]
WORKDIR "/src/src/ShamiCafe.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ShamiCafe.Web.Host", "src/ShamiCafe.Web.Host"]
COPY ["src/ShamiCafe.Web.Core", "src/ShamiCafe.Web.Core"]
COPY ["src/ShamiCafe.Application", "src/ShamiCafe.Application"]
COPY ["src/ShamiCafe.Core", "src/ShamiCafe.Core"]
COPY ["src/ShamiCafe.EntityFrameworkCore", "src/ShamiCafe.EntityFrameworkCore"]
WORKDIR "/src/src/ShamiCafe.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ShamiCafe.Web.Host.dll"]
