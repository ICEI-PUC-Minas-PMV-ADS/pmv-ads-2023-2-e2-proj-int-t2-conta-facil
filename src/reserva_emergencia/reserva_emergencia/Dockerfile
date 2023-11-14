#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["reserva_emergencia/reserva_emergencia.csproj", "reserva_emergencia/"]
RUN dotnet restore "reserva_emergencia/reserva_emergencia.csproj"
COPY . .
WORKDIR "/src/reserva_emergencia"
RUN dotnet build "reserva_emergencia.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "reserva_emergencia.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "reserva_emergencia.dll"]