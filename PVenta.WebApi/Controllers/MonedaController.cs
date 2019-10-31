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
        public bool InsertMoneda(ApiMoneda moneda)
        {
            bool resultInsert = false;
            if (ModelState.IsValid)
            {
                Moneda monedaInsert = objMapper.CreateMapper().Map<Moneda>(moneda);
                resultInsert = serviceMoneda.InsertMoneda(monedaInsert);
            }

            return resultInsert;
        }

        [HttpPost]
        public bool UpdateMoneda(ApiMoneda moneda)
        {
            bool resultUpdate = false;
            if (ModelState.IsValid)
            {
                Moneda monedaUpdate = objMapper.CreateMapper().Map<Moneda>(moneda);
                resultUpdate = serviceMoneda.UpdateMoneda(monedaUpdate);
            }
            return resultUpdate;
        }

        [HttpPost]
        public bool DeleteMoneda(string id)
        {
            bool resultDelete = false;
            Moneda monedaDelete = serviceMoneda.GetMoneda(id);
            if (monedaDelete != null)
            {
                resultDelete = serviceMoneda.DeleteMoneda(id); 
            }


            return resultDelete;
        }

    }
}
