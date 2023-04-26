using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class Product : BaseEntity<int>
    {
        [Required(ErrorMessage = "Ad boş ola bilməz")]
        public string Name { get; set; }//+
        [Required(ErrorMessage = "Parametr boş ola bilməz")]
        public string TextParametr { get; set; }
        public string IsFreeDelivery { get; set; }
        [Required(ErrorMessage = "Qiymət boş ola bilməz")]
        public decimal Price { get; set; }//+
        [Required(ErrorMessage = "Məhsul sayı boş ola bilməz")]
        public short Count { get; set; }//+
        public decimal? DisCount { get; set; }//+
        [Required(ErrorMessage = "Qaranti müddəti boş ola bilməz")]
        public byte? WarrantyYearNumber { get; set; }//+
        public ICollection<Image> Images { get; set; }//+
        [Required(ErrorMessage = "Brand boş ola bilməz")]
        public int BrandId { get; set; }//+
        public Brand Brand { get; set; }
        [Required(ErrorMessage = "Kateqoriya boş ola bilməz")]
        public int SubCategoryId { get; set; }//+
        public SubCategory SubCategory { get; set; }
        public int? ViewCount { get; set; }
        public ICollection<ProductParametr> ProductParametrs { get; set; }
        public int? OfferCompanyId { get; set; }//+
        public OfferCompany OfferCompany { get; set; }
        [NotMapped]
        public List<Brand> Brands { get; set; }
        [NotMapped]
        public List<SubCategory>  SubCategories { get; set; }
        [NotMapped]
        public List<OfferCompany> OfferCompanies { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Şəkil boş ola bilməz")]
        public List<IFormFile> FormFiles { get; set; }
    }
}
