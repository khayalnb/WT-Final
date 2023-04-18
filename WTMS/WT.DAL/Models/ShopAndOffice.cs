using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class ShopAndOffice:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Adress  { get; set; }
        public string Phone { get; set; }
        public int AdressTypeId { get; set; }
        public AdressType AdressType { get; set; }
        public string MapUrl { get; set; }
        [NotMapped]
        public List<AdressType> AdressTypes { get; set; }
    }
}
