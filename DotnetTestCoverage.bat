rem Install Tools
dotnet tool install --global coverlet.console
dotnet tool install -g dotnet-reportgenerator-globaltool

rem Install packages to test projects
dotnet add package coverlet.msbuild

rem Generate XML report unit test coverage and show table
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit.*]"

rem Generate reports unit test coverage
reportgenerator "-reports:./IFCPosManagerApi.Tests/coverage.cobertura.xml" "-targetdir:./IFCPosManagerApi.Tests/CoverReport"
./IFCPosManagerApi.Tests/CoverReport/index.html

reportgenerator "-reports:./IFCWebApi.Tests/coverage.cobertura.xml" "-targetdir:./IFCWebApi.Tests/CoverReport"
./IFCWebApi.Tests/CoverReport/index.html

