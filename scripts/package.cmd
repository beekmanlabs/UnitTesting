rm *.nupkg
%userprofile%\bin\nuget.exe pack BeekmanLabs.UnitTesting\BeekmanLabs.UnitTesting.csproj -Prop Configuration=Release -Prop Platform=AnyCPU
