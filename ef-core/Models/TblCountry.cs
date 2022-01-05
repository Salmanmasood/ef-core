using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblStates = new HashSet<TblState>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryFlag { get; set; }

        public virtual ICollection<TblState> TblStates { get; set; }
    }
}
