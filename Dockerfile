#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LGC_Check_In.csproj", "."]
RUN dotnet restore "./LGC_Check_In.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "LGC_Check_In.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LGC_Check_In.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LGC_Check_In.dll"]