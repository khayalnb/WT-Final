using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebUI.ViewModels
{
    public class CompaignVM
    {
        public OfferCompany OfferCompany { get; set; }
        public List<Product> Products { get; set; }
    }
}
