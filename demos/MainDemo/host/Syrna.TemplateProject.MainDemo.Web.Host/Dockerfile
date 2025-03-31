#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["host/Syrna.TemplateProject.Web.Unified/Syrna.TemplateProject.Web.Unified.csproj", "host/Syrna.TemplateProject.Web.Unified/"]
COPY ["src/Syrna.TemplateProject.Web/Syrna.TemplateProject.Web.csproj", "src/Syrna.TemplateProject.Web/"]
COPY ["src/Syrna.TemplateProject.HttpApi/Syrna.TemplateProject.HttpApi.csproj", "src/Syrna.TemplateProject.HttpApi/"]
COPY ["src/Syrna.TemplateProject.Application.Contracts/Syrna.TemplateProject.Application.Contracts.csproj", "src/Syrna.TemplateProject.Application.Contracts/"]
COPY ["src/Syrna.TemplateProject.Domain.Shared/Syrna.TemplateProject.Domain.Shared.csproj", "src/Syrna.TemplateProject.Domain.Shared/"]
COPY ["src/Syrna.TemplateProject.Application/Syrna.TemplateProject.Application.csproj", "src/Syrna.TemplateProject.Application/"]
COPY ["src/Syrna.TemplateProject.Domain/Syrna.TemplateProject.Domain.csproj", "src/Syrna.TemplateProject.Domain/"]
COPY ["src/Syrna.TemplateProject.EntityFrameworkCore/Syrna.TemplateProject.EntityFrameworkCore.csproj", "src/Syrna.TemplateProject.EntityFrameworkCore/"]
COPY ["host/Syrna.TemplateProject.Host.Shared/Syrna.TemplateProject.Host.Shared.csproj", "host/Syrna.TemplateProject.Host.Shared/"]
COPY Directory.Build.props .
RUN dotnet restore "host/Syrna.TemplateProject.Web.Unified/Syrna.TemplateProject.Web.Unified.csproj"
COPY . .
WORKDIR "/src/host/Syrna.TemplateProject.Web.Unified"
RUN dotnet build "Syrna.TemplateProject.Web.Unified.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Syrna.TemplateProject.Web.Unified.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Syrna.TemplateProject.Web.Unified.dll"]