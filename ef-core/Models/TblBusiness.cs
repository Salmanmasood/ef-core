using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblBusiness
    {
        public TblBusiness()
        {
            ContextMappedBusinesses = new HashSet<ContextMappedBusiness>();
        }

        public int BId { get; set; }
        public string BText { get; set; }
        public string BShortdesc { get; set; }
        public string BLongdesc { get; set; }
        public int? BCatId { get; set; }
        public int? BAddressId { get; set; }
        public string BImage { get; set; }
        public bool? BStatus { get; set; }
        public int? BSubCategory { get; set; }
        public DateTime? BAddedDate { get; set; }
        public DateTime? BModifiedDate { get; set; }
        public string BName { get; set; }
        public string BMinSalary { get; set; }
        public string BMaxSalary { get; set; }
        public string BMinExperience { get; set; }
        public string BMaxExperience { get; set; }

        public virtual ICollection<ContextMappedBusiness> ContextMappedBusinesses { get; set; }
    }
}
