
# Use the official ASP.NET SDK image for building
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8.1 AS build
RUN mkdir app
RUN cmd /S /C "icacls C:\app /grant Everyone:(OI)(CI)F"
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WebApp2/*.csproj ./WebApp2/
COPY WebApp2/*.config ./WebApp2/
RUN nuget restore WebApp2.sln

# copy SourceCode and build app
COPY WebApp2/. ./WebApp2/
WORKDIR /app/WebApp2
RUN msbuild /p:Configuration=Release -r:False

# Create application image on official ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8.1 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/WebApp2/. ./