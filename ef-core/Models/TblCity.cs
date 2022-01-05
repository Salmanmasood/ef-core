using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblCity
    {
        public int CitiesId { get; set; }
        public string CitiesName { get; set; }
        public string CitiesCode { get; set; }
        public int? CitiesStateId { get; set; }

        public virtual TblState CitiesState { get; set; }
    }
}
