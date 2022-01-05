using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblState
    {
        public TblState()
        {
            TblCities = new HashSet<TblCity>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int? StateCountryId { get; set; }

        public virtual TblCountry StateCountry { get; set; }
        public virtual ICollection<TblCity> TblCities { get; set; }
    }
}
