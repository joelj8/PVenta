using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class UsuarioProfile: Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, ApiUsuario>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Pwduser, opts => opts.MapFrom(src => src.Pwduser))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Email))
                .ForMember(dest => dest.RolId, opts => opts.MapFrom(src => src.RolId))
                .ForMember(dest => dest.Rol, opts => opts.MapFrom(src => src.Rol))
                .ForMember(dest => dest.esCajero, opts => opts.MapFrom(src => src.esCajero))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}