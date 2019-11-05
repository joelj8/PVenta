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
    public class MesaController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceMesa serviceMesa;

        public MesaController()
        {
            serviceMesa = new ServiceMesa();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new MesaProfile());
            profileList.Add(new MMesaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }
    
    
        public JsonResult<List<ApiMesa>> GetMesas()
        {
            List<Mesa> mesaLista = serviceMesa.GetMesas();
            List<ApiMesa> mesa = objMapper.CreateMapper().Map<List<ApiMesa>>(mesaLista);
            return Json<List<ApiMesa>>(mesa);
        }

        public JsonResult<ApiMesa> GetMesa(string id)
        {
            Mesa mesaLista = serviceMesa.GetMesa(id);
            ApiMesa mesa = objMapper.CreateMapper().Map<ApiMesa>(mesaLista);
            return Json<ApiMesa>(mesa);
        }

        [HttpPost]
        public MessageApp InsertMesa(ApiMesa mesa)
        {
            MessageApp resultinsert = null;
            if (ModelState.IsValid)
            {
                Mesa mesaInsert = objMapper.CreateMapper().Map<Mesa>(mesa);
                resultinsert = serviceMesa.InsertMesa(mesaInsert);
            }
            return resultinsert;
        }

        [HttpPost]
        public MessageApp UpdateMesa(ApiMesa mesa)
        {
            MessageApp resultUpdate = null;
            if (ModelState.IsValid)
            {
                Mesa mesaUpdate = objMapper.CreateMapper().Map<Mesa>(mesa);
                resultUpdate = serviceMesa.UpdateMesa(mesaUpdate);
            }
            return resultUpdate;
        }

        [HttpPost]
        public MessageApp DeleteMesa(string id)
        {
            MessageApp resultDelete = null;
            resultDelete = serviceMesa.DeleteMesa(id);
            return resultDelete;
        }

    }
}
