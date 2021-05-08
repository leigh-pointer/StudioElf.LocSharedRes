using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Oqtane.Modules;
using Oqtane.Repository;
using StudioElf.LocSharedRes.Models;

namespace StudioElf.LocSharedRes.Repository
{
    public class LocSharedResContext : DBContextBase, IService
    {
        public virtual DbSet<Models.LocSharedRes> LocSharedRes { get; set; }

        public LocSharedResContext(ITenantResolver tenantResolver, IHttpContextAccessor accessor) : base(tenantResolver, accessor)
        {
            // ContextBase handles multi-tenant database connections
        }
    }
}
