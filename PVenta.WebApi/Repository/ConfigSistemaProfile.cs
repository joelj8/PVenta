using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class ConfigSistemaProfile: Profile
    {
        public ConfigSistemaProfile()
        {
            CreateMap<ApiConfigSistema, ConfigSistema>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.CalcITBIS, opts => opts.MapFrom(src => src.CalcITBIS))
                .ForMember(dest => dest.CodigoSegInactivar, opts => opts.MapFrom(src => src.CodigoSegInactivar))
                .ForMember(dest => dest.ComprobanteFiscal, opts => opts.MapFrom(src => src.ComprobanteFiscal))
                .ForMember(dest => dest.Direccion, opts => opts.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.FechaInicio, opts => opts.MapFrom(src => src.FechaInicio))
                .ForMember(dest => dest.ImprimeComandaAuto, opts => opts.MapFrom(src => src.ImprimeComandaAuto))
                .ForMember(dest => dest.ImprimeFacturaAuto, opts => opts.MapFrom(src => src.ImprimeFacturaAuto))
                .ForMember(dest => dest.ImprimeOrdenAuto, opts => opts.MapFrom(src => src.ImprimeOrdenAuto))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo))
                .ForMember(dest => dest.RelacionID, opts => opts.MapFrom(src => src.RelacionID))
                .ForMember(dest => dest.InfoDigitals, opts => opts.MapFrom(src => src.InfoDigitals))
                .ForMember(dest => dest.MensajeFactura, opts => opts.MapFrom(src => src.MensajeFactura))
                .ForMember(dest => dest.MensajeOrden, opts => opts.MapFrom(src => src.MensajeOrden))
                .ForMember(dest => dest.NombreComercial, opts => opts.MapFrom(src => src.NombreComercial))
                .ForMember(dest => dest.NombreNeg, opts => opts.MapFrom(src => src.NombreNeg))
                .ForMember(dest => dest.NumComprobanteFiscal, opts => opts.MapFrom(src => src.NumComprobanteFiscal))
                .ForMember(dest => dest.PorcITBIS, opts => opts.MapFrom(src => src.PorcITBIS))
                .ForMember(dest => dest.RNC, opts => opts.MapFrom(src => src.RNC))
                .ForMember(dest => dest.Telefono, opts => opts.MapFrom(src => src.Telefono));
        }
    }
}