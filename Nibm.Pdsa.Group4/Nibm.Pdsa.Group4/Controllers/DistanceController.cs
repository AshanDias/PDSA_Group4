using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;

namespace Nibm.Pdsa.Group4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        private readonly IApplicationService _applicationService;
        public DistanceController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        // GET: api/Distance
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Distance/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Distance
        [HttpPost]
        public  int Post(Distance distance)
        {
           return  _applicationService.SaveDistance(distance);

        }

        // PUT: api/Distance/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
