using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class Category:BaseEntity<int>
    {
        
        [Required(ErrorMessage = "Ad boş ola bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Icon boş ola bilməz")]
        public string Icon { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
