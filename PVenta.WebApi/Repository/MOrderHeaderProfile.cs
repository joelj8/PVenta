using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class MOrderHeaderProfile : Profile
    {
        public MOrderHeaderProfile()
        {
            CreateMap<OrderHeader, ApiOrderHeader>()
            .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
            .ForMember(dest => dest.NumOrden, opts => opts.MapFrom(src => src.NumOrden))
            .ForMember(dest => dest.ClientePrincipal, opts => opts.MapFrom(src => src.ClientePrincipal))
            .ForMember(dest => dest.DescMonto, opts => opts.MapFrom(src => src.DescMonto))
            .ForMember(dest => dest.DescPorc, opts => opts.MapFrom(src => src.DescPorc))
            .ForMember(dest => dest.Fecha, opts => opts.MapFrom(src => src.Fecha))
            .ForMember(dest => dest.FechaRegistro, opts => opts.MapFrom(src => src.FechaRegistro))
            .ForMember(dest => dest.Impreso, opts => opts.MapFrom(src => src.Impreso))
            .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo))
            .ForMember(dest => dest.Itbis, opts => opts.MapFrom(src => src.Itbis))
            .ForMember(dest => dest.ItbisPorc, opts => opts.MapFrom(src => src.ItbisPorc))
            .ForMember(dest => dest.Servicio, post => post.MapFrom(src => src.Servicio))
            .ForMember(dest => dest.ServicioPorc, post => post.MapFrom(src => src.ServicioPorc))
            .ForMember(dest => dest.MesaId, opts => opts.MapFrom(src => src.MesaId))
            .ForMember(dest => dest.Mesa, opts => opts.MapFrom(src => src.Mesa))
            .ForMember(dest => dest.OrderDetails, opts => opts.MapFrom(src => src.OrderDetails));
            
            
            
        }
    }
}