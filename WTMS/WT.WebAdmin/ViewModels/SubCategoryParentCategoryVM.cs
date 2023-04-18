using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebAdmin.ViewModels
{
    public class SubCategoryParentCategoryVM
    {
        public SubCategory SubCategory { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
