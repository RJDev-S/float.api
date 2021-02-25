#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#generate runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Float.Api/Float.Api.csproj", "Float.Api/"]
COPY ["Float.Application/Float.Application.csproj", "Float.Application/"]
COPY ["Float.Domain/Float.Domain.csproj", "Float.Domain/"]
COPY ["Float.Infrastracture.Persistence/Float.Infrastracture.Persistence.csproj", "Float.Infrastracture.Persistence/"]
COPY ["Float.Infrastracture.Identity/Float.Infrastracture.Identity.csproj", "Float.Infrastracture.Identity/"]
RUN dotnet restore "Float.Api/Float.Api.csproj"
COPY . .
WORKDIR "/src/Float.Api"
RUN dotnet build "Float.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Float.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Float.Api.dll"]