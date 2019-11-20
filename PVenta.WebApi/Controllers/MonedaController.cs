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
    public class MonedaController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceMoneda serviceMoneda;

        public MonedaController()
        {
            serviceMoneda = new ServiceMoneda();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new MonedaProfile());
            profileList.Add(new MMonedaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiMoneda>> GetMonedas()
        {
           
            List<Moneda> monedaLista = serviceMoneda.GetMonedas();
            List<ApiMoneda> moneda = objMapper.CreateMapper().Map<List<ApiMoneda>>(monedaLista);
            return Json<List<ApiMoneda>>(moneda);
        }

        public JsonResult<ApiMoneda> GetMoneda(string id)
        {
            Moneda monedaLista = serviceMoneda.GetMoneda(id);
            ApiMoneda moneda = objMapper.CreateMapper().Map<ApiMoneda>(monedaLista);
            return Json<ApiMoneda>(moneda);
        }

        [HttpPost]
        public HttpResponseMessage InsertMoneda(ApiMoneda moneda)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Moneda monedaInsert = objMapper.CreateMapper().Map<Moneda>(moneda);
                result = serviceMoneda.InsertMoneda(monedaInsert);
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
        public HttpResponseMessage UpdateMoneda(ApiMoneda moneda)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Moneda monedaUpdate = objMapper.CreateMapper().Map<Moneda>(moneda);
                result = serviceMoneda.UpdateMoneda(monedaUpdate);
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
        public HttpResponseMessage DeleteMoneda(string id)
        {
            MessageApp result = null;
            result = serviceMoneda.DeleteMoneda(id);

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
