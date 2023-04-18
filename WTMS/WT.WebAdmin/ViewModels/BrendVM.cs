using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebAdmin.ViewModels
{
    public class BrendVM
    {
        public List<Brand> Brands { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
