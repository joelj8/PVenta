using AutoMapper;
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
    public class TypeInformacionController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceTypeInformacion serviceTypeInformacion;

        public TypeInformacionController()
        {
            serviceTypeInformacion = new ServiceTypeInformacion();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new TypeInformacionProfile());
            profileList.Add(new MTypeInformacionProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiTypeInformacion>> GetTypeInformaciones()
        {
            List<TypeInformacion> typeInformacionLista = serviceTypeInformacion.GetTypeInformacions();
            List<ApiTypeInformacion> typeInformacion = objMapper.CreateMapper().Map<List<ApiTypeInformacion>>(typeInformacionLista);
            return Json<List<ApiTypeInformacion>>(typeInformacion);
        }

        public JsonResult<ApiTypeInformacion> GetTypeInformacion(string id)
        {
            TypeInformacion typeInformacionResult = serviceTypeInformacion.GetTypeInformacion(id);
            ApiTypeInformacion typeInformacion = objMapper.CreateMapper().Map<ApiTypeInformacion>(typeInformacionResult);
            return Json<ApiTypeInformacion>(typeInformacion);
        }

        [HttpPost]
        public HttpResponseMessage InsertTypeInformacion(ApiTypeInformacion typeInformacion)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                TypeInformacion typeInformacionInsert = objMapper.CreateMapper().Map<TypeInformacion>(typeInformacion);
                result = serviceTypeInformacion.InsertTypeInformacion(typeInformacionInsert);
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
        public HttpResponseMessage UpdateTypeInformacion(ApiTypeInformacion typeInformacion)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                TypeInformacion typeInformacionUpdate = objMapper.CreateMapper().Map<TypeInformacion>(typeInformacion);
                result = serviceTypeInformacion.UpdateTypeInformacion(typeInformacionUpdate);
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
        public HttpResponseMessage DeleteTypeInformacion(string id)
        {
            MessageApp result = null;
            result = serviceTypeInformacion.DeleteTypeInformacion(id);

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
