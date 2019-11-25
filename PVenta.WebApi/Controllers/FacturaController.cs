using AutoMapper;
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
    public class FacturaController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceFactura serviceFactura;
        private readonly JsonSerializerSettings jsonsettings;
           
        public FacturaController()
        {
            jsonsettings = new JsonSerializerSettings();
            jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            serviceFactura = new ServiceFactura();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new FacturaHeaderProfile());
            profileList.Add(new MFacturaHeaderProfile());
            profileList.Add(new FacturaDetailProfile());
            profileList.Add(new MFacturaDetailProfile());
            profileList.Add(new FacturaPaymentProfile());
            profileList.Add(new MFacturaPaymentProfile());
            profileList.Add(new ProductoProfile());
            profileList.Add(new MProductoProfile());
            profileList.Add(new CategoriaProfile());
            profileList.Add(new MCategoriaProfile());
            profileList.Add(new MesaProfile());
            profileList.Add(new MMesaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }


        public JsonResult<List<ApiFacturaHeader>> GetFacturas()
        {
            List<FacturaHeader> facturaLista = serviceFactura.GetFacturas();
            List<ApiFacturaHeader> factura = objMapper.CreateMapper().Map<List<ApiFacturaHeader>>(facturaLista);
            // 2019.11.12 
            // Este es un ejemplo retornando un JsonResult de una clase 
            // que al convertirla utilizará los parametros de configuracion de un objecto de JsonSerializerSettings
            // JsonSerializerSettings jsonsettings = new JsonSerializerSettings();
            // jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // Este codigo Ignora los Loop en las clases que se hacen referencias una a otra, evitando redundancia.

            return Json<List<ApiFacturaHeader>>(factura, jsonsettings);
        }


        public JsonResult<ApiFacturaHeader> GetFactura(string id)
        {
            FacturaHeader facturaLista = serviceFactura.GetFactura(id);
            ApiFacturaHeader factura = objMapper.CreateMapper().Map<ApiFacturaHeader>(facturaLista);

            return Json<ApiFacturaHeader>(factura, jsonsettings);
        }

        [HttpPost]
        public HttpResponseMessage InsertFactura(ApiFacturaHeader facturaHeader)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                FacturaHeader facturaHeaderInsert = objMapper.CreateMapper().Map<FacturaHeader>(facturaHeader);
                result = serviceFactura.InsertFacturaHeader(facturaHeaderInsert);
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
        public HttpResponseMessage UpdateFactura(ApiFacturaHeader facturaHeader)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                FacturaHeader facturaHeaderUpdate = objMapper.CreateMapper().Map<FacturaHeader>(facturaHeader);
                result = serviceFactura.UpdateFacturaHeader(facturaHeaderUpdate);
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
        public HttpResponseMessage DeleteFactura(string id)
        {
            MessageApp result = null;
            result = serviceFactura.DeleteFacturaHeader(id);

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
