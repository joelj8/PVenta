using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Web.Script.Serialization;

namespace PVenta.WebApi.Controllers
{
    public class OrderController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceOrder serviceOrder;
        private readonly JsonSerializerSettings jsonsettings;

        public OrderController()
        {
            jsonsettings = new JsonSerializerSettings();
            jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            serviceOrder = new ServiceOrder();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new OrderHeaderProfile());
            profileList.Add(new MOrderHeaderProfile());
            profileList.Add(new OrderDetailProfile());
            profileList.Add(new MOrderDetailProfile());
            profileList.Add(new ProductoProfile());
            profileList.Add(new MProductoProfile());
            profileList.Add(new CategoriaProfile());
            profileList.Add(new MCategoriaProfile());
            profileList.Add(new MesaProfile());
            profileList.Add(new MMesaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }
  
        public JsonResult<List<ApiOrderHeader>> GetOrders()
        {
            List<OrderHeader> orderLista = serviceOrder.GetOrderHeaders();
            List<ApiOrderHeader> order = objMapper.CreateMapper().Map<List<ApiOrderHeader>>(orderLista);
            // 2019.11.12 
            // Este es un ejemplo retornando un JsonResult de una clase 
            // que al convertirla utilizará los parametros de configuracion de un objecto de JsonSerializerSettings
            // JsonSerializerSettings jsonsettings = new JsonSerializerSettings();
            // jsonsettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // Este codigo Ignora los Loop en las clases que se hacen referencias una a otra, evitando redundancia.

            return Json<List<ApiOrderHeader>>(order,jsonsettings);
        }

        private JsonResult<ApiOrderHeader> GetOrder(string id)
        {
            OrderHeader orderLista = serviceOrder.GetOrderHeader(id);
            ApiOrderHeader order = objMapper.CreateMapper().Map<ApiOrderHeader>(orderLista);

            return Json<ApiOrderHeader>(order,jsonsettings);

        }

        public ApiOrderHeader Getprueba(string id)
        {   
            // 2019.11.12 - Este metodo no se utiliza, solo es para pruebas
            // Este es un ejemplo retornando una clase que será convertida a Json
            // y al convertirla utilizará los parametros de configuracion del WebApiConfig.cs
            // config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Error;
            // Este codigo Ignora los Loop en las clases que se hacen referencias una a otra, evitando redundancia.
            OrderHeader orderLista = serviceOrder.GetOrderHeader(id);
            ApiOrderHeader order = objMapper.CreateMapper().Map<ApiOrderHeader>(orderLista);

            return order;

        }

        [HttpPost]
        public MessageApp InsertOrder(ApiOrderHeader orderHeader)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                OrderHeader orderHeaderInsert = objMapper.CreateMapper().Map<OrderHeader>(orderHeader);
                result = serviceOrder.InsertOrderHeader(orderHeaderInsert);
            }
            return result;
        }

        [HttpPost]
        public MessageApp UpdateOrder(ApiOrderHeader orderHeader)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                OrderHeader orderHeaderUpdate = objMapper.CreateMapper().Map<OrderHeader>(orderHeader);
                result = serviceOrder.UpdateOrderHeader(orderHeaderUpdate);
            }
            return result;
        }

        [HttpPost]
        public MessageApp DeleteOrder(string id)
        {
            MessageApp result = null;
            result = serviceOrder.DeleteOrderHeader(id);

            return result;
        }

    }
}
