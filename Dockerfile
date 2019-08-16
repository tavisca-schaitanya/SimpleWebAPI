#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
COPY ./SimpleWebAPI/bin/Debug/netcoreapp2.1/publish .
ENTRYPOINT ["dotnet", "SimpleCoreWebAPI.dll"]
