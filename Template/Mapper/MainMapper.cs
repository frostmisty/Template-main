using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domain.Entity;
using Template.Features;
using Template.ViewModels;

namespace Template.Mapper
{
    public class MainMapper : Profile
    {
        public MainMapper()
        {
            CreateMap<MsModule, MsModuleViewModel>().ReverseMap();
            CreateMap<MsModule, MsModuleFeatures>().ReverseMap();
        }
    }
}
