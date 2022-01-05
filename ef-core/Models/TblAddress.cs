using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblAddress
    {
        public TblAddress()
        {
            TblCarBusinesses = new HashSet<TblCarBusiness>();
            TblPropertyBusinesses = new HashSet<TblPropertyBusiness>();
        }

        public int AdId { get; set; }
        public string AdText { get; set; }
        public string AdPhone { get; set; }
        public string AdPhone2 { get; set; }
        public int? AdCity { get; set; }
        public string AdZipcode { get; set; }
        public string AdEmail { get; set; }

        public virtual ICollection<TblCarBusiness> TblCarBusinesses { get; set; }
        public virtual ICollection<TblPropertyBusiness> TblPropertyBusinesses { get; set; }
    }
}
