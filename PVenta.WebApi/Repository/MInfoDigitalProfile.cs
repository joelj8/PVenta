using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PVenta.WebApi.Repository
{
    public class MInfoDigitalProfile : Profile
    {
        public MInfoDigitalProfile()
        {
            CreateMap<InfoDigital,ApiInfoDigital>()
                .ForMember(dest => dest.ID, opts => opts.MapFrom(src => src.ID))
                .ForMember(dest => dest.Descripcion, opts => opts.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.RelacionID, opts => opts.MapFrom(src => src.RelacionID))
                .ForMember(dest => dest.TypeInfoID, opts => opts.MapFrom(src => src.TypeInfoID))
                .ForMember(dest => dest.TypeInfo, opts => opts.MapFrom(src => src.TypeInfo))
                .ForMember(dest => dest.Inactivo, opts => opts.MapFrom(src => src.Inactivo));
        }
         
    }
}