using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblPropertyBusiness
    {
        public int PId { get; set; }
        public string PText { get; set; }
        public string PShortdesc { get; set; }
        public string PLongdesc { get; set; }
        public int? PCatId { get; set; }
        public int? PAddressId { get; set; }
        public string PImage { get; set; }
        public int? PSubCategory { get; set; }
        public DateTime? PAddedDate { get; set; }
        public DateTime? PModifiedDate { get; set; }
        public string PPrice { get; set; }

        public virtual TblAddress PAddress { get; set; }
        public virtual TblCategory PCat { get; set; }
    }
}
