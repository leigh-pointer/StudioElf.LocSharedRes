using System.Collections.Generic;
using System.Threading.Tasks;
using StudioElf.LocSharedRes.Models;

namespace StudioElf.LocSharedRes.Services
{
    public interface ILocSharedResService 
    {
        Task<List<Models.LocSharedRes>> GetLocSharedRessAsync(int ModuleId);

        Task<Models.LocSharedRes> GetLocSharedResAsync(int LocSharedResId, int ModuleId);

        Task<Models.LocSharedRes> AddLocSharedResAsync(Models.LocSharedRes LocSharedRes);

        Task<Models.LocSharedRes> UpdateLocSharedResAsync(Models.LocSharedRes LocSharedRes);

        Task DeleteLocSharedResAsync(int LocSharedResId, int ModuleId);
    }
}
