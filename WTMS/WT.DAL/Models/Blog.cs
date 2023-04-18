using System.ComponentModel.DataAnnotations.Schema;
using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class Blog:BaseEntity<int>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageName { get; set; }
    }
}
