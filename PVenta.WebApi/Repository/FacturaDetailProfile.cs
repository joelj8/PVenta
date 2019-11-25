using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class FacturaDetailProfile: Profile
    {
        public FacturaDetailProfile()
        {
            CreateMap<ApiFacturaDetail, FacturaDetail>()
                .ForMember(dest => dest.ID, post => post.MapFrom(src => src.ID))
                .ForMember(dest => dest.Cantidad, post => post.MapFrom(src => src.Cantidad))
                .ForMember(dest => dest.Precio, post => post.MapFrom(src => src.Precio))
                .ForMember(dest => dest.ClientePedido, post => post.MapFrom(src => src.ClientePedido))
                .ForMember(dest => dest.FacturaHID, post => post.MapFrom(src => src.FacturaHID))
                .ForMember(dest => dest.FacturaHeader, post => post.MapFrom(src => src.FacturaHeader))
                .ForMember(dest => dest.ImpComanda, post => post.MapFrom(src => src.ImpComanda))
                .ForMember(dest => dest.Impreso, post => post.MapFrom(src => src.Impreso))
                .ForMember(dest => dest.Inactivo, post => post.MapFrom(src => src.Inactivo))
                .ForMember(dest => dest.OrderDID, post => post.MapFrom(src => src.OrderDID))
                .ForMember(dest => dest.Orden, post => post.MapFrom(src => src.Orden))
                .ForMember(dest => dest.ProductoID, post => post.MapFrom(src => src.ProductoID))
                .ForMember(dest => dest.producto, post => post.MapFrom(src => src.producto));
        }
    }
}