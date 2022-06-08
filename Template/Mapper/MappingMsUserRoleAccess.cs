﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domain.Entity;
using Template.ViewModels;

namespace Template.Mapper
{
    public class MappingMsUserRoleAccess : Profile
    {
        public MappingMsUserRoleAccess()
        {
            CreateMap<MsUserRoleAccess, MsUserRoleAccessViewModel>().ReverseMap();
        }
    }
}
