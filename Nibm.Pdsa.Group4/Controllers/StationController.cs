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
    public class StationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public StationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;

        }
        // GET: api/Station
        [HttpGet]
        public List<Station> Get()
        {
            return _applicationService.GetAllStations();
        }

        // GET: api/Station/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Station
        [HttpPost]
        public int Post(Station stations)
        {
            if (stations.Id != 0)
            {
                return _applicationService.UpdateStation(stations);
            }
            else
            {
                return _applicationService.SaveStation(stations);

            }
          
        }
       

        // PUT: api/Station/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [Route("Delete")]
        [HttpPost]
        public int Remove(Station stations)
        {
            
            return _applicationService.DeleteStation(stations.Id); 
        }
    }
}
