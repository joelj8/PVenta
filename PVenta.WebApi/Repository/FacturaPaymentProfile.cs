using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class FacturaPaymentProfile : Profile
    {
        public FacturaPaymentProfile()
        {
            CreateMap<ApiFacturaPayment, FacturaPayment>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.FacturaHID, opts => opts.MapFrom(src => src.FacturaHID))
                .ForMember(dest => dest.FacturaHeader, opts => opts.MapFrom(src => src.FacturaHeader))
                .ForMember(dest => dest.FechaPago, opts => opts.MapFrom(src => src.FechaPago))
                .ForMember(dest => dest.MontoPago, opts => opts.MapFrom(src => src.MontoPago))
                .ForMember(dest => dest.MontoDevolver, opts => opts.MapFrom(src => src.MontoDevolver))
                .ForMember(dest => dest.FormaPago, opts => opts.MapFrom(src => src.FormaPago))
                .ForMember(dest => dest.FormaPagoId, opts => opts.MapFrom(src => src.FormaPagoId))
                .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}