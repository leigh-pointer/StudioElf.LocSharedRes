using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Oqtane.Modules;
using StudioElf.LocSharedRes.Models;

namespace StudioElf.LocSharedRes.Repository
{
    public class LocSharedResRepository : ILocSharedResRepository, IService
    {
        private readonly LocSharedResContext _db;

        public LocSharedResRepository(LocSharedResContext context)
        {
            _db = context;
        }

        public IEnumerable<Models.LocSharedRes> GetLocSharedRess(int ModuleId)
        {
            return _db.LocSharedRes.Where(item => item.ModuleId == ModuleId);
        }

        public Models.LocSharedRes GetLocSharedRes(int LocSharedResId)
        {
            return _db.LocSharedRes.Find(LocSharedResId);
        }

        public Models.LocSharedRes AddLocSharedRes(Models.LocSharedRes LocSharedRes)
        {
            _db.LocSharedRes.Add(LocSharedRes);
            _db.SaveChanges();
            return LocSharedRes;
        }

        public Models.LocSharedRes UpdateLocSharedRes(Models.LocSharedRes LocSharedRes)
        {
            _db.Entry(LocSharedRes).State = EntityState.Modified;
            _db.SaveChanges();
            return LocSharedRes;
        }

        public void DeleteLocSharedRes(int LocSharedResId)
        {
            Models.LocSharedRes LocSharedRes = _db.LocSharedRes.Find(LocSharedResId);
            _db.LocSharedRes.Remove(LocSharedRes);
            _db.SaveChanges();
        }
    }
}
