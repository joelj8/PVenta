using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class RolProfile : Profile
    {
        public RolProfile()
        {
            CreateMap<Rol, ApiRol>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Modificable, opts => opts.MapFrom(src => src.Modificable))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}