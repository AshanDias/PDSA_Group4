using Microsoft.EntityFrameworkCore;
using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Service
{
    public class ApplicationService : IApplicationService
    {
        private readonly ApplicationContext _applicationContext;
        public ApplicationService()
        {

        }

        public ApplicationService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }

        public  List<string> GetDistance()
        {
            return _applicationContext.Distance.Select(x => x.fromStation).Distinct().ToList();
        }
    }
}
