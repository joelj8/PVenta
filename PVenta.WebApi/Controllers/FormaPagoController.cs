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
    public class FormaPagoController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceFormaPago serviceFormaPago;

        public FormaPagoController()
        {
            serviceFormaPago = new ServiceFormaPago();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new FormaPagoProfile());
            profileList.Add(new MFormaPagoProfile());
            profileList.Add(new MonedaProfile());
            profileList.Add(new MMonedaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }
   
        public JsonResult<List<ApiFormaPago>> GetFormaPagos()
        {
            List<FormaPago> formaPagoLista = serviceFormaPago.GetFormaPagos();
            List<ApiFormaPago> formaPago = objMapper.CreateMapper().Map<List<ApiFormaPago>>(formaPagoLista);
            return Json<List<ApiFormaPago>>(formaPago);
        }

        public JsonResult<ApiFormaPago> GetFormaPago(string id)
        {
            FormaPago formaPagoLista = serviceFormaPago.GetFormaPago(id);
            ApiFormaPago formaPago = objMapper.CreateMapper().Map<ApiFormaPago>(formaPagoLista);
            return Json<ApiFormaPago>(formaPago);
        }

        [HttpPost]
        public HttpResponseMessage InsertFormaPago(ApiFormaPago formaPagoNew)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                FormaPago formaPagoInsert = objMapper.CreateMapper().Map<FormaPago>(formaPagoNew);
                result = serviceFormaPago.InsertFormaPago(formaPagoInsert);
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
        public HttpResponseMessage UpdateFormaPago(ApiFormaPago formaPagoUpd)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                FormaPago formaPagoUpdate = objMapper.CreateMapper().Map<FormaPago>(formaPagoUpd);
                result = serviceFormaPago.UpdateFormaPago(formaPagoUpdate);
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
        public HttpResponseMessage DeleteFormaPago(string id)
        {
            MessageApp result = null;
            result = serviceFormaPago.DeleteFormaPago(id);

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
