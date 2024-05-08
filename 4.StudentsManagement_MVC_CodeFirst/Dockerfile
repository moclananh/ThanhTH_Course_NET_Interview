FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY 4.StudentsManagement_MVC_CodeFirst.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "4.StudentsManagement_MVC_CodeFirst.dll"]