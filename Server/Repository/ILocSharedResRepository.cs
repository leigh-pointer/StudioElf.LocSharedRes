using System.Collections.Generic;
using StudioElf.LocSharedRes.Models;

namespace StudioElf.LocSharedRes.Repository
{
    public interface ILocSharedResRepository
    {
        IEnumerable<Models.LocSharedRes> GetLocSharedRess(int ModuleId);
        Models.LocSharedRes GetLocSharedRes(int LocSharedResId);
        Models.LocSharedRes AddLocSharedRes(Models.LocSharedRes LocSharedRes);
        Models.LocSharedRes UpdateLocSharedRes(Models.LocSharedRes LocSharedRes);
        void DeleteLocSharedRes(int LocSharedResId);
    }
}
