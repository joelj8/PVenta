﻿using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class MOpcionesSistProfile : Profile
    {
        public MOpcionesSistProfile()
        {
            CreateMap<OpcionesSist, ApiOpcionesSist>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Codigo, opts => opts.MapFrom(src => src.Codigo))
                .ForMember(dest => dest.Descripcion, opts => opts.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}