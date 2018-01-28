using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIENN.WebApi.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<SIENN.DbAccess.Models.Product, SIENN.DataContracts.Product>();
        }
    }
}
