﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors("AllowOrigin")]
        public List<Distance> Get()
        {
            return _applicationService.GetAllDistance();
        }

        // GET: api/Distance/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Distance
        [HttpPost]
        [EnableCors("AllowOrigin")]
        public  int Post(Distance distance)
        {
            if (distance.Id != 0)
            {
               return _applicationService.UpdateDistance(distance);
                
            }
            else
            {

              return  _applicationService.SaveDistance(distance);
            }
          

        }

        // PUT: api/Distance/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Distance/Delete
        [Route("Delete")]
        [HttpPost]
        [EnableCors("AllowOrigin")]
        public int Remove(Distance distance)
        {

            return _applicationService.DeleteDistance(distance.Id);
        }
    }
}
