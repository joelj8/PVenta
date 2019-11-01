using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class LogEventoProfile: Profile 
    {
        public LogEventoProfile()
        {
            CreateMap<LogEvento, ApiLogEvento>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Fecha, opts => opts.MapFrom(src => src.Fecha))
                .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Usuario, opts => opts.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.TipoEvento, opts => opts.MapFrom(src => src.TipoEvento))
                .ForMember(dest => dest.ErrorListId, opts => opts.MapFrom(src => src.ErrorListId))
                .ForMember(dest => dest.ErrorList, opts => opts.MapFrom(src => src.ErrorList))
                .ForMember(dest => dest.msgError, opts => opts.MapFrom(src => src.msgError));
        }
    }
}