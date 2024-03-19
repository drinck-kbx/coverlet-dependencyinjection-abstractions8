# coverlet-dependencyinjection-abstractions8
Small working example to reproduce a coverage issue with .NET 8 and coverlet 6.0.2

### Working Example in .NET 6:

Steps:
1. `dotnet build`
2. `dotnet publish` 
3. `dotnet test -p:CopyLocalLockFileAssemblies=true --collect="XPlat Code Coverage" -c=Debug -p:CollectCoverage=true --results-directory=./TestResults/ -verbosity:diagnostic --diag ./TestResults/___log.txt`

Notice in the coverage.cobertura.xml file: `lines-covered="3" lines-valid="6" `
This is the expected result.


### To see Coverage Issue in .NET 8.: 
1. Update TargetFramework to net8.0 in Host and Test Projects
2. Update Microsoft.Extensions.DependencyInjection.Abstractions to Version="8.0.0" in both .csproj files
3. Rerun dotnet build/publish/test steps from above.

Notice in the coverage.cobertura.xml file that `lines-covered="0" lines-valid="0"`
An error will appear in the ___log.datacollector.x.txt file:

`Failed to resolve assembly: 'Microsoft.Extensions.DependencyInjection.Abstractions, Version=6.0.0.0 `
