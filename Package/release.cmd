"..\..\Oqtane.Framework\oqtane.package\nuget.exe" pack StudioElf.LocSharedRes.nuspec 
Rem Create Language Package
"..\..\Oqtane.Framework\oqtane.package\nuget.exe" pack StudioElf.LocSharedRes.nl-NL.nuspec 
XCOPY "*.nupkg" "..\..\Oqtane.Framework\Oqtane.Server\wwwroot\Modules\" /Y
