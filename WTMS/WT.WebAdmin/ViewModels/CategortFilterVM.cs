using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.WebAdmin.ViewModels
{
    public class CategortFilterVM
    {
        public string Query { get; set; }
        public List<Category> Categories { get; set; }
    }
}
