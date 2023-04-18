using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class OfferCompany:BaseEntity<int>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
        public string ImageName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
