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

        public OrderController()
        {
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
            return Json<List<ApiOrderHeader>>(order);
        }

        public JsonResult<ApiOrderHeader> GetOrder(string id)
        {
            OrderHeader orderLista = serviceOrder.GetOrderHeader(id);
            ApiOrderHeader order = objMapper.CreateMapper().Map<ApiOrderHeader>(orderLista);
            /*
            string preserveReferenacesAll = JsonConvert.SerializeObject(order, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.All
            });

            JObject json = JObject.Parse(preserveReferenacesAll);

            //var result = Json(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            */
            return Json<ApiOrderHeader>(order);
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
