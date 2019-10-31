using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class PermisosRolProfile : Profile
    {
        public PermisosRolProfile()
        {
            CreateMap<ApiPermisosRol, PermisosRol>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.RolId, opts => opts.MapFrom(src => src.RolId))
                .ForMember(dest => dest.Rol, opts => opts.MapFrom(src => src.Rol))
                .ForMember(dest => dest.OpcionId, opts => opts.MapFrom(src => src.OpcionId))
                .ForMember(dest => dest.OpcionesSist, opts => opts.MapFrom(src => src.OpcionesSist))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}