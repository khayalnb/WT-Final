using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebAdmin.ViewModels
{
    public class ProductParametrVM
    {
        public Product Product { get; set; }
        public List<ProductParametr> ProductParametrs { get; set; }
    }
}
