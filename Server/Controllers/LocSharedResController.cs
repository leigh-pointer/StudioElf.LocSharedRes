using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Oqtane.Shared;
using Oqtane.Enums;
using Oqtane.Infrastructure;
using StudioElf.LocSharedRes.Models;
using StudioElf.LocSharedRes.Repository;

namespace StudioElf.LocSharedRes.Controllers
{
    [Route(ControllerRoutes.Default)]
    public class LocSharedResController : Controller
    {
        private readonly ILocSharedResRepository _LocSharedResRepository;
        private readonly ILogManager _logger;
        protected int _entityId = -1;

        public LocSharedResController(ILocSharedResRepository LocSharedResRepository, ILogManager logger, IHttpContextAccessor accessor)
        {
            _LocSharedResRepository = LocSharedResRepository;
            _logger = logger;

            if (accessor.HttpContext.Request.Query.ContainsKey("entityid"))
            {
                _entityId = int.Parse(accessor.HttpContext.Request.Query["entityid"]);
            }
        }

        // GET: api/<controller>?moduleid=x
        [HttpGet]
        [Authorize(Policy = PolicyNames.ViewModule)]
        public IEnumerable<Models.LocSharedRes> Get(string moduleid)
        {
            return _LocSharedResRepository.GetLocSharedRess(int.Parse(moduleid));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Authorize(Policy = PolicyNames.ViewModule)]
        public Models.LocSharedRes Get(int id)
        {
            Models.LocSharedRes LocSharedRes = _LocSharedResRepository.GetLocSharedRes(id);
            if (LocSharedRes != null && LocSharedRes.ModuleId != _entityId)
            {
                LocSharedRes = null;
            }
            return LocSharedRes;
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize(Policy = PolicyNames.EditModule)]
        public Models.LocSharedRes Post([FromBody] Models.LocSharedRes LocSharedRes)
        {
            if (ModelState.IsValid && LocSharedRes.ModuleId == _entityId)
            {
                LocSharedRes = _LocSharedResRepository.AddLocSharedRes(LocSharedRes);
                _logger.Log(LogLevel.Information, this, LogFunction.Create, "LocSharedRes Added {LocSharedRes}", LocSharedRes);
            }
            return LocSharedRes;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Policy = PolicyNames.EditModule)]
        public Models.LocSharedRes Put(int id, [FromBody] Models.LocSharedRes LocSharedRes)
        {
            if (ModelState.IsValid && LocSharedRes.ModuleId == _entityId)
            {
                LocSharedRes = _LocSharedResRepository.UpdateLocSharedRes(LocSharedRes);
                _logger.Log(LogLevel.Information, this, LogFunction.Update, "LocSharedRes Updated {LocSharedRes}", LocSharedRes);
            }
            return LocSharedRes;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Policy = PolicyNames.EditModule)]
        public void Delete(int id)
        {
            Models.LocSharedRes LocSharedRes = _LocSharedResRepository.GetLocSharedRes(id);
            if (LocSharedRes != null && LocSharedRes.ModuleId == _entityId)
            {
                _LocSharedResRepository.DeleteLocSharedRes(id);
                _logger.Log(LogLevel.Information, this, LogFunction.Delete, "LocSharedRes Deleted {LocSharedResId}", id);
            }
        }
    }
}
