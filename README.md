# coverlet-dependencyinjection-abstractions8
Small working example to reproduce a coverage issue with .NET 8 and coverlet 6.0.2

### To see Coverage Issue in .NET 8.: 
Steps:
1. `dotnet build`
2. `dotnet test -p:CopyLocalLockFileAssemblies=true --collect="XPlat Code Coverage" -c=Debug -p:CollectCoverage=true --results-directory=./TestResults/ -verbosity:diagnostic --diag ./TestResults/___log.txt`

Notice in the coverage.cobertura.xml file that `lines-covered="0" lines-valid="0"`
An error will appear in the ___log.datacollector.x.txt file:

`Mono.Cecil.AssemblyResolutionException: Failed to resolve assembly: 'Microsoft.Extensions.DependencyInjection.Abstractions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'`

Can be fixed by uncommenting these lines in `MissingCoverage.Tests.csproj`:

```
<!--  <Target Name="FixCodeCoverage" AfterTargets="Build" Condition=" '$(CollectCoverage)' == 'true' ">-->
<!--    <Copy-->
<!--            SourceFiles="$(ProjectDir)$(OutputPath)refs\Microsoft.Extensions.DependencyInjection.Abstractions.dll"-->
<!--            DestinationFolder="$(ProjectDir)$(OutputPath)"-->
<!--    />-->
<!--    <Copy-->
<!--            SourceFiles="$(ProjectDir)$(OutputPath)refs\Microsoft.Extensions.Logging.Abstractions.dll"-->
<!--            DestinationFolder="$(ProjectDir)$(OutputPath)"-->
<!--    />-->
<!--  </Target>-->
```
