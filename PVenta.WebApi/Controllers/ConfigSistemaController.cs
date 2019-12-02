using AutoMapper;
using Newtonsoft.Json;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using PVenta.Services;
using PVenta.Utility;
using PVenta.WebApi.Repository;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace PVenta.WebApi.Controllers
{
    public class ConfigSistemaController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceConfigSistema servicioConfigSistema;
        private readonly JsonSerializerSettings jsonsettings;
        public ConfigSistemaController()
        {
            jsonsettings = new JsonSerializerSettings();
            jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            servicioConfigSistema = new ServiceConfigSistema();

            List<Profile> profileList = new List<Profile>();
            
            profileList.Add(new ConfigSistemaProfile());
            profileList.Add(new MConfigSistemaProfile());
            profileList.Add(new InfoDigitalProfile());
            profileList.Add(new MInfoDigitalProfile());
            profileList.Add(new TypeInformacionProfile());
            profileList.Add(new MTypeInformacionProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));

        }

        public JsonResult<List<ApiConfigSistema>> GetConfigSistemas()
        {
            List<ConfigSistema> configSistemaLista = servicioConfigSistema.GetConfigSistemas();
            List<ApiConfigSistema> configSistema = objMapper.CreateMapper().Map<List<ApiConfigSistema>>(configSistemaLista);

            return Json<List<ApiConfigSistema>>(configSistema, jsonsettings);
        }

        public JsonResult<ApiConfigSistema> GetConfigSistema(string id)
        {
            ConfigSistema configSistemaLista = servicioConfigSistema.GetConfigSistema(id);
            ApiConfigSistema configSistema = objMapper.CreateMapper().Map<ApiConfigSistema>(configSistemaLista);

            return Json<ApiConfigSistema>(configSistema, jsonsettings);
        }

        [HttpPost]
        public HttpResponseMessage InsertConfigSistema(ApiConfigSistema configSistema)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                ConfigSistema configSistemaInsert = objMapper.CreateMapper().Map<ConfigSistema>(configSistema);
                result = servicioConfigSistema.InsertConfigSistema(configSistemaInsert);
            }

            if (result == null || result.esError)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateConfigSistema(ApiConfigSistema configSistema)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                ConfigSistema configSistemaUpdate = objMapper.CreateMapper().Map<ConfigSistema>(configSistema);
                result = servicioConfigSistema.UpdateConfigSistema(configSistemaUpdate);
            }

            if (result == null || result.esError)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
        }

        [HttpPost]
        public HttpResponseMessage DeleteConfigSistema(string id)
        {
            MessageApp result = null;
            result = servicioConfigSistema.DeleteConfigSistema(id);

            if (result == null || result.esError)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

        }

    }
}
