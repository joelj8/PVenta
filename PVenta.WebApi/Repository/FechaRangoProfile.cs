using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class FechaRangoProfile : Profile
    {
        public FechaRangoProfile()
        {
            CreateMap<ApiFechaRango, FechaRango>()
                .ForMember(dest => dest.FechaInicio, opts => opts.MapFrom(src => src.FechaInicio))
                .ForMember(dest => dest.FechaFin, opts => opts.MapFrom(src => src.FechaFin));
        }
    }
}