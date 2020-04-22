using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nibm.Pdsa.Group4.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
