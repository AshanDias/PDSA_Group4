using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Service;

namespace Nibm.Pdsa.Group4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortestPathController : ControllerBase
    {
        int[,] arr = null;

        private readonly IShortestPath _shortestPath;
        private readonly IHashMapDistances _hashMapDistances;
        private readonly ILocationService _locationService;
        private readonly IApplicationService _applicationService;

        string[] branches = null;
        string[,] ss = null;

        public ShortestPathController(IShortestPath path, IHashMapDistances hash, ILocationService locationService, IApplicationService applicationService)
        {
            _shortestPath = path;
            _hashMapDistances = hash;
            _locationService = locationService;
            _applicationService = applicationService;
          
            
            try
            {
                branches = getArray();
                ss = _locationService.PrintArray();
                _shortestPath = _shortestPath = new ShortestPath(ss.Length, getArray());

                _hashMapDistances = new HashMapDistances(ss.Length, getArray());
            }
            catch(Exception ex)
            {

            }

            arr = new int[ss.Length,ss.Length];
            for (int i = 0; i < ss.GetLength(0); i++)
            {
                for (int y = 0; y < ss.GetLength(1); y++)
                {
                    int val = 0;
                    if (ss[i,y] != null)
                    {

                        val = Convert.ToInt32(ss[i,y]);
                    }
                    else
                    {
                        val = 0;
                    }

                    arr[i,y] = val;

                }

            }
        }


        public  int findIndex(string[] arr, string t)
        {

            // if array is Null 
            if (arr == null)
            {
                return -1;
            }

            // find length of array 
            int len = arr.Length;
            int i = 0;

            // traverse in the array 
            while (i < len)
            {

                // if the i-th element is t 
                // then return the index 
                if (arr[i].Equals(t))
                {
                    return i;
                }
                else
                {
                    i = i + 1;
                }
            }
            return -1;
        }

        // GET: api/ShortestPath
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShortestPath/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
             int index = findIndex(branches, "Galle");
            return "value";
        }

        // POST: api/ShortestPath
        [HttpPost]
        public void Post([FromBody] string value)
        {
           
        }

        // PUT: api/ShortestPath/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }




       public  string[] getArray()
        {

            string[] branches = null;
            List<string> list = new List<string>();

            list = _applicationService.GetDistance();

            branches = list.ToArray();

            return branches;
        }
   }
}
