using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class MErrorListProfile: Profile
    {
        public MErrorListProfile()
        {
            CreateMap<ErrorList,ApiErrorList>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Codigo, opts => opts.MapFrom(src => src.Codigo))
                .ForMember(dest => dest.MsgError, opts => opts.MapFrom(src => src.MsgError))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
    }
}