dotnet new webapi --no-https
dotnet build
dotnet run
dotnet tool install -g Microsoft.dotnet-httprepl
httprepl http://localhost:5000  OR  (Disconnected)> connect http://localhost:5000
