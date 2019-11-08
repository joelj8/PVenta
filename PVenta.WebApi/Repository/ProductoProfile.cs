using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<ApiProducto, Producto>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.NombreCorto, opts => opts.MapFrom(src => src.NombreCorto))
                .ForMember(dest => dest.Precio, opts => opts.MapFrom(src => src.Precio))
                .ForMember(dest => dest.CategoriaId, opts => opts.MapFrom(src => src.CategoriaId))
                .ForMember(dest => dest.Categoria, opts => opts.MapFrom(src => src.Categoria))
                .ForMember(dest => dest.ImpComanda, opts => opts.MapFrom(src => src.ImpComanda))
                .ForMember(dest => dest.esAdicional, opts => opts.MapFrom(src => src.esAdicional))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}