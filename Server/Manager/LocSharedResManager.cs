using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Oqtane.Modules;
using Oqtane.Models;
using Oqtane.Infrastructure;
using Oqtane.Repository;
using StudioElf.LocSharedRes.Models;
using StudioElf.LocSharedRes.Repository;

namespace StudioElf.LocSharedRes.Manager
{
    public class LocSharedResManager : IInstallable, IPortable
    {
        private ILocSharedResRepository _LocSharedResRepository;
        private ISqlRepository _sql;

        public LocSharedResManager(ILocSharedResRepository LocSharedResRepository, ISqlRepository sql)
        {
            _LocSharedResRepository = LocSharedResRepository;
            _sql = sql;
        }

        public bool Install(Tenant tenant, string version)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "StudioElf.LocSharedRes." + version + ".sql");
        }

        public bool Uninstall(Tenant tenant)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "StudioElf.LocSharedRes.Uninstall.sql");
        }

        public string ExportModule(Module module)
        {
            string content = "";
            List<Models.LocSharedRes> LocSharedRess = _LocSharedResRepository.GetLocSharedRess(module.ModuleId).ToList();
            if (LocSharedRess != null)
            {
                content = JsonSerializer.Serialize(LocSharedRess);
            }
            return content;
        }

        public void ImportModule(Module module, string content, string version)
        {
            List<Models.LocSharedRes> LocSharedRess = null;
            if (!string.IsNullOrEmpty(content))
            {
                LocSharedRess = JsonSerializer.Deserialize<List<Models.LocSharedRes>>(content);
            }
            if (LocSharedRess != null)
            {
                foreach(var LocSharedRes in LocSharedRess)
                {
                    _LocSharedResRepository.AddLocSharedRes(new Models.LocSharedRes { ModuleId = module.ModuleId, Name = LocSharedRes.Name });
                }
            }
        }
    }
}