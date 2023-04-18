using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.DAL.Models
{
    public class CorporativeSale:BaseEntity.BaseEntity<int>
    {
        [Column (TypeName ="text")]
        public string  Content { get; set; }
    }
}
