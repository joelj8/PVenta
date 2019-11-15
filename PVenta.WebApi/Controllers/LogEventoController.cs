﻿using AutoMapper;
using Newtonsoft.Json;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using PVenta.Services;
using PVenta.Utility;
using PVenta.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace PVenta.WebApi.Controllers
{
    public class LogEventoController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceLogEvento serviceLogEvento;
        private readonly JsonSerializerSettings jsonsettings;

        public LogEventoController()
        {
            serviceLogEvento = new ServiceLogEvento();
            jsonsettings = new JsonSerializerSettings();
            jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new LogEventoProfile());
            profileList.Add(new MLogEventoProfile());
            profileList.Add(new UsuarioProfile());
            profileList.Add(new MUsuarioProfile());
            profileList.Add(new RolProfile());
            profileList.Add(new MRolProfile());
            profileList.Add(new ErrorListProfile());
            profileList.Add(new MErrorListProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));

        }
    
        public JsonResult<List<ApiLogEvento>> GetLogEventos()
        {
            List<LogEvento> logEventosLista = serviceLogEvento.GetLogEventos();
            List<ApiLogEvento> logEventos = objMapper.CreateMapper().Map<List<ApiLogEvento>>(logEventosLista);
            return Json<List<ApiLogEvento>>(logEventos,jsonsettings);
        }

        public JsonResult<ApiLogEvento> GetLogEvento(string id)
        {
            LogEvento logEventosLista = serviceLogEvento.GetLogEvento(id);
            ApiLogEvento logEventos = objMapper.CreateMapper().Map<ApiLogEvento>(logEventosLista);
            return Json<ApiLogEvento>(logEventos,jsonsettings);
        }

        [HttpPost]
        public MessageApp InsertLogEvento(ApiLogEvento logEvento)
        {
            MessageApp resultinsert = null;
            LogEvento logEventoInsert = objMapper.CreateMapper().Map<LogEvento>(logEvento);
            resultinsert = serviceLogEvento.InsertLogEvento(logEventoInsert);
            return resultinsert;
        }

        [HttpPost]
        public MessageApp UpdateLogEvento(ApiLogEvento logEvento)
        {
            MessageApp resultUpdate = null;

            LogEvento logEventoUpdate = objMapper.CreateMapper().Map<LogEvento>(logEvento);
            resultUpdate = serviceLogEvento.UpdateLogEvento(logEventoUpdate);

            return resultUpdate;

        }


    }
}
