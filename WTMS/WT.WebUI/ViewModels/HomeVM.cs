using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebUI.ViewModels
{
    public class HomeVM
    {
        public List<OfferCompany> OfferCompanies { get; set; }
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
