using Oqtane.Models;
using Oqtane.Modules;

namespace StudioElf.LocSharedRes
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "LocSharedRes",
            Description = "LocSharedRes",
            Version = "1.0.0",
            ServerManagerType = "StudioElf.LocSharedRes.Manager.LocSharedResManager, StudioElf.LocSharedRes.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "StudioElf.LocSharedRes.Shared.Oqtane"
        };
    }
}
