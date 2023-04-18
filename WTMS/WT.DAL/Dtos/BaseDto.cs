using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.DAL.Dtos
{
    public class BaseDto<Type>
    {
        public Type Id { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public DateTime? Deleted_Date { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
