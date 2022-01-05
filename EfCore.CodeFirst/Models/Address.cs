using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }

        public Employee Employee { get; set; }

    }
}
