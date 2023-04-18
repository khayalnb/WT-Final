using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class SubCategory:BaseEntity<int>
    {

        [Required(ErrorMessage = "Ad boş ola bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kateqoriya boş ola bilməz")]
        public int?  CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
