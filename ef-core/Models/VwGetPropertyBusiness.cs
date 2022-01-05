using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class VwGetPropertyBusiness
    {
        public DateTime? PAddedDate { get; set; }
        public DateTime? PModifiedDate { get; set; }
        public int AddressId { get; set; }
        public string FullAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int? City { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public int BusinessId { get; set; }
        public string PropertyTitle { get; set; }
        public string ShortDesc { get; set; }
        public string Filters { get; set; }
        public int? CategoryId { get; set; }
        public string BusinessImage { get; set; }
        public string Category { get; set; }
        public string CategoryIcon { get; set; }
        public int? SubCategory { get; set; }
        public string PropertyPrice { get; set; }
    }
}
