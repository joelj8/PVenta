using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class CategoriaProfile: Profile
    {
        public CategoriaProfile()
        {
            CreateMap<ApiCategoria, Categoria>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Descripcion, opts => opts.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.ImpComanda, opts => opts.MapFrom(src => src.ImpComanda))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}