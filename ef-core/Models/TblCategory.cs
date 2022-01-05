using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblCarBusinesses = new HashSet<TblCarBusiness>();
            TblPropertyBusinesses = new HashSet<TblPropertyBusiness>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatIcon { get; set; }
        public DateTime? CatAddedDate { get; set; }
        public DateTime? CatUpdateDate { get; set; }
        public int? CatMasterCategory { get; set; }
        public string CatFilter { get; set; }

        public virtual ICollection<TblCarBusiness> TblCarBusinesses { get; set; }
        public virtual ICollection<TblPropertyBusiness> TblPropertyBusinesses { get; set; }
    }
}
