using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using PVenta.Services;
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

        public LogEventoController()
        {
            serviceLogEvento = new ServiceLogEvento();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new LogEventoProfile());
            profileList.Add(new MLogEventoProfile());
            profileList.Add(new UsuarioProfile());
            profileList.Add(new MUsuarioProfile());
            profileList.Add(new RolProfile());
            profileList.Add(new MRolProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));

        }
    
        public JsonResult<List<ApiLogEvento>> GetLogEventos()
        {
            List<LogEvento> logEventosLista = serviceLogEvento.GetLogEventos();
            List<ApiLogEvento> logEventos = objMapper.CreateMapper().Map<List<ApiLogEvento>>(logEventosLista);
            return Json<List<ApiLogEvento>>(logEventos);
        }

        public JsonResult<ApiLogEvento> GetLogEvento(string id)
        {
            LogEvento logEventosLista = serviceLogEvento.GetLogEvento(id);
            ApiLogEvento logEventos = objMapper.CreateMapper().Map<ApiLogEvento>(logEventosLista);
            return Json<ApiLogEvento>(logEventos);
        }

        [HttpPost]
        public bool InsertLogEvento(ApiLogEvento logEvento)
        {
            bool resultinsert = false;
            LogEvento logEventoInsert = objMapper.CreateMapper().Map<LogEvento>(logEvento);
            resultinsert = serviceLogEvento.InsertLogEvento(logEventoInsert);
            return resultinsert;
        }

        [HttpPost]
        public bool UpdateLogEvento(ApiLogEvento logEvento)
        {
            bool resultUpdate = false;

            LogEvento logEventoUpdate = objMapper.CreateMapper().Map<LogEvento>(logEvento);
            resultUpdate = serviceLogEvento.UpdateLogEvento(logEventoUpdate);

            return resultUpdate;

        }


    }
}
