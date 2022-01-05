using System;
using System.Collections.Generic;

#nullable disable

namespace ef_core.Models
{
    public partial class CategoryContext
    {
        public CategoryContext()
        {
            ContextMappedBusinesses = new HashSet<ContextMappedBusiness>();
        }

        public int Id { get; set; }
        public string ContextType { get; set; }
        public string ContextKey { get; set; }

        public virtual ICollection<ContextMappedBusiness> ContextMappedBusinesses { get; set; }
    }
}
