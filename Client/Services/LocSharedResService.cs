using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Oqtane.Modules;
using Oqtane.Services;
using Oqtane.Shared;
using StudioElf.LocSharedRes.Models;

namespace StudioElf.LocSharedRes.Services
{
    public class LocSharedResService : ServiceBase, ILocSharedResService, IService
    {
        private readonly SiteState _siteState;

        public LocSharedResService(HttpClient http, SiteState siteState) : base(http)
        {
            _siteState = siteState;
        }

         private string Apiurl => CreateApiUrl(_siteState.Alias, "LocSharedRes");

        public async Task<List<Models.LocSharedRes>> GetLocSharedRessAsync(int ModuleId)
        {
            List<Models.LocSharedRes> LocSharedRess = await GetJsonAsync<List<Models.LocSharedRes>>(CreateAuthorizationPolicyUrl($"{Apiurl}?moduleid={ModuleId}", ModuleId));
            return LocSharedRess.ToList();  //.OrderBy(item => item.Name).ToList();
        }

        public async Task<Models.LocSharedRes> GetLocSharedResAsync(int LocSharedResId, int ModuleId)
        {
            return await GetJsonAsync<Models.LocSharedRes>(CreateAuthorizationPolicyUrl($"{Apiurl}/{LocSharedResId}", ModuleId));
        }

        public async Task<Models.LocSharedRes> AddLocSharedResAsync(Models.LocSharedRes LocSharedRes)
        {
            return await PostJsonAsync<Models.LocSharedRes>(CreateAuthorizationPolicyUrl($"{Apiurl}", LocSharedRes.ModuleId), LocSharedRes);
        }

        public async Task<Models.LocSharedRes> UpdateLocSharedResAsync(Models.LocSharedRes LocSharedRes)
        {
            return await PutJsonAsync<Models.LocSharedRes>(CreateAuthorizationPolicyUrl($"{Apiurl}/{LocSharedRes.LocSharedResId}", LocSharedRes.ModuleId), LocSharedRes);
        }

        public async Task DeleteLocSharedResAsync(int LocSharedResId, int ModuleId)
        {
            await DeleteAsync(CreateAuthorizationPolicyUrl($"{Apiurl}/{LocSharedResId}", ModuleId));
        }
    }
}
