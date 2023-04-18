using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class ProductParametr:BaseEntity<int>
    {
        public string? ParamKey { get; set; }
        public string? ParamValue { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
