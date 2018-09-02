FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 55279
EXPOSE 44307

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TaskManagerASP/TaskManagerASP.csproj", "TaskManagerASP/"]
RUN dotnet restore "TaskManagerASP/TaskManagerASP.csproj"
COPY . .
WORKDIR "/src/TaskManagerASP"
RUN dotnet build "TaskManagerASP.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TaskManagerASP.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TaskManagerASP.dll"]