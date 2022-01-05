using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore.CodeFirst.Models
{
    [Table("Tbl_Country")]
    public class Country
    {
        [Column("CountryId", TypeName = "int")]
        [Key]
        public int Id { get; set; }

        [Column("CountryName", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="Country Name cannot be null")]
        public string Name { get; set; }

        [Column("CountryCode")]
        [MaxLength(10)]
        [MinLength(2)]
        [Required(ErrorMessage = "Short Code cannot be null")]
        public string ShortCode { get; set; }
        [NotMapped]
        public int Count { get; set; } //will not create a column against this property.....

        public ICollection<City> City { get; set; }

    }
}
