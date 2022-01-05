using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class ContextMappedBusiness
    {
        public int Id { get; set; }
        public int? ContextId { get; set; }
        public int? BusinessId { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? AddedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual TblBusiness Business { get; set; }
        public virtual CategoryContext Context { get; set; }
    }
}
