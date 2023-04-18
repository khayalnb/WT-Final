using System.Collections.Generic;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class OrderComplate:BaseEntity<int>
    {
        public int OrderNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
