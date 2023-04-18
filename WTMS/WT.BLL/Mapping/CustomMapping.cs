using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.DAL.Dtos;
using WT.DAL.Models;

namespace WT.BLL.Mapping
{
    public class CustomMapping:Profile
    {
        public CustomMapping()
        {
            CreateMap<BlogDto, Blog>().ReverseMap();
        }
    }
}
