FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TestContainerApi/TestContainerApi.csproj", "TestContainerApi/"]
RUN dotnet restore "TestContainerApi/TestContainerApi.csproj"
COPY . .
WORKDIR "/src/TestContainerApi"
RUN dotnet build "TestContainerApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TestContainerApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestContainerApi.dll"]