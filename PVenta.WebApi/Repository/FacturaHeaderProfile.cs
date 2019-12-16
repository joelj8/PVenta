using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class FacturaHeaderProfile : Profile
    {
        public FacturaHeaderProfile()
        {
            CreateMap<ApiFacturaHeader, FacturaHeader>()
                .ForMember(dest => dest.ID, post => post.MapFrom(src => src.ID))
                .ForMember(dest => dest.NumFactura, post => post.MapFrom(src => src.NumFactura))
                .ForMember(dest => dest.Fecha, post => post.MapFrom(src => src.Fecha))
                .ForMember(dest => dest.UserId, post => post.MapFrom(src => src.UserId))
                .ForMember(dest => dest.MesaId, post => post.MapFrom(src => src.MesaId))
                .ForMember(dest => dest.Mesa, post => post.MapFrom(src => src.Mesa))
                .ForMember(dest => dest.ClientePrincipal, post => post.MapFrom(src => src.ClientePrincipal))
                .ForMember(dest => dest.Itbis, post => post.MapFrom(src => src.Itbis))
                .ForMember(dest => dest.ItbisPorc, post => post.MapFrom(src => src.ItbisPorc))
                .ForMember(dest => dest.DescMonto, post => post.MapFrom(src => src.DescMonto))
                .ForMember(dest => dest.DescPorc, post => post.MapFrom(src => src.DescPorc))
                .ForMember(dest => dest.FechaRegistro, post => post.MapFrom(src => src.FechaRegistro))
                .ForMember(dest => dest.Impreso, post => post.MapFrom(src => src.Impreso))
                .ForMember(dest => dest.Inactivo, post => post.MapFrom(src => src.Inactivo))
                .ForMember(dest => dest.Servicio, post => post.MapFrom(src => src.Servicio))
                .ForMember(dest => dest.ServicioPorc, post => post.MapFrom(src => src.ServicioPorc))
                .ForMember(dest => dest.OrderHID, post => post.MapFrom(src => src.OrderHID))
                .ForMember(dest => dest.FacturaDetails, post => post.MapFrom(src => src.FacturaDetails))
                .ForMember(dest => dest.FacturaPayments, post => post.MapFrom(src => src.FacturaPayments));
        }
    }
}