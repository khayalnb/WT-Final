using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.DAL.Dtos
{
    public class BlogDto:BaseDto<int>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
    }
}
