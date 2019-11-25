using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class MOrderDetailProfile : Profile
    {
        public MOrderDetailProfile()
        {
            CreateMap<OrderDetail,ApiOrderDetail>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Cantidad, opts => opts.MapFrom(src => src.Cantidad))
                .ForMember(dest => dest.ClientePedido, opts => opts.MapFrom(src => src.ClientePedido))
                .ForMember(dest => dest.ImpComanda, opts => opts.MapFrom(src => src.ImpComanda))
                .ForMember(dest => dest.Impreso, opts => opts.MapFrom(src => src.Impreso))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo))
                .ForMember(dest => dest.OrderHID, opts => opts.MapFrom(src => src.OrderHID))
                .ForMember(dest => dest.OrderHeader, opts => opts.MapFrom(src => src.OrderHeader))
                .ForMember(dest => dest.Precio, opts => opts.MapFrom(src => src.Precio))
                .ForMember(dest => dest.ProductoID, opts => opts.MapFrom(src => src.ProductoID))
                .ForMember(dest => dest.producto, opts => opts.MapFrom(src => src.producto))
                .ForMember(dest => dest.Orden, opts => opts.MapFrom(src => src.Orden));
        }
    }
}