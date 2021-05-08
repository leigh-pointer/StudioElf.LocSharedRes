XCOPY "..\Client\bin\Debug\net5.0\StudioElf.LocSharedRes.Client.Oqtane.dll" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
XCOPY "..\Client\bin\Debug\net5.0\StudioElf.LocSharedRes.Client.Oqtane.pdb" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
XCOPY "..\Server\bin\Debug\net5.0\StudioElf.LocSharedRes.Server.Oqtane.dll" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
XCOPY "..\Server\bin\Debug\net5.0\StudioElf.LocSharedRes.Server.Oqtane.pdb" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
XCOPY "..\Shared\bin\Debug\net5.0\StudioElf.LocSharedRes.Shared.Oqtane.dll" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
XCOPY "..\Shared\bin\Debug\net5.0\StudioElf.LocSharedRes.Shared.Oqtane.pdb" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\" /Y
Rem Copy Language
XCOPY "..\Client\bin\Debug\net5.0\nl-NL\StudioElf.LocSharedRes.Client.Oqtane.resources.dll" "..\..\Oqtane.Framework\Oqtane.Server\bin\Debug\net5.0\nl-NL\" /Y

XCOPY "..\Server\wwwroot\*" "..\..\Oqtane.Framework\Oqtane.Server\wwwroot\" /Y /S /I
