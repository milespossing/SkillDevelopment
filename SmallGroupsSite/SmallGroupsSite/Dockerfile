FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52059
EXPOSE 44311

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["SmallGroupsSite/SmallGroupsSite.csproj", "SmallGroupsSite/"]
RUN dotnet restore "SmallGroupsSite/SmallGroupsSite.csproj"
COPY . .
WORKDIR "/src/SmallGroupsSite"
RUN dotnet build "SmallGroupsSite.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SmallGroupsSite.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SmallGroupsSite.dll"]