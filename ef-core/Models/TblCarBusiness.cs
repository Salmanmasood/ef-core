using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class TblCarBusiness
    {
        public int CarId { get; set; }
        public string CarText { get; set; }
        public string CarShortdesc { get; set; }
        public string CarLongdesc { get; set; }
        public int? CarCatId { get; set; }
        public int? CarAddressId { get; set; }
        public string CarImage { get; set; }
        public int? CarSubCategory { get; set; }
        public DateTime? CarAddedDate { get; set; }
        public DateTime? CarModifiedDate { get; set; }
        public string CarPrice { get; set; }

        public virtual TblAddress CarAddress { get; set; }
        public virtual TblCategory CarCat { get; set; }
    }
}
