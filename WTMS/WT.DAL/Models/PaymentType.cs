using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class PaymentType:BaseEntity<int>
    {
        public string PaymentTypeName { get; set; }
    }
}
