using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebUI.ViewModels
{
    public class ProductFilterVM
    {
        public List<int> BrandSearch { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool LessToMore { get; set; }
    }

}
