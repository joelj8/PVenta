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
    public class OpcionesSistController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceOpcionesSist serviceOpcionesSist;

        public OpcionesSistController()
        {
            serviceOpcionesSist = new ServiceOpcionesSist();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new OpcionesSistProfile());
            profileList.Add(new MOpcionesSistProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiOpcionesSist>> GetOpcionesSists()
        {
            List<OpcionesSist> opcionesSistsLista = serviceOpcionesSist.GetOpcionesSists();
            List<ApiOpcionesSist> opcionesSists = objMapper.CreateMapper().Map<List<ApiOpcionesSist>>(opcionesSistsLista);
            return Json<List<ApiOpcionesSist>>(opcionesSists);
        }

        public JsonResult<ApiOpcionesSist> GetOpcionesSist(string id)
        {
            OpcionesSist opcionesSistsLista = serviceOpcionesSist.GetOpcionesSist(id);
            ApiOpcionesSist opcionesSists = objMapper.CreateMapper().Map<ApiOpcionesSist>(opcionesSistsLista);
            return Json<ApiOpcionesSist>(opcionesSists);
        }

        [HttpPost]
        public MessageApp InsertOpcionesSist(ApiOpcionesSist opcionesSist)
        {
            MessageApp resultInsert = null;
            if (ModelState.IsValid)
            {
                OpcionesSist opcionesSistInsert = objMapper.CreateMapper().Map<OpcionesSist>(opcionesSist);
                resultInsert = serviceOpcionesSist.InsertOpcionesSist(opcionesSistInsert);
            }

            return resultInsert;
        }

        [HttpPost]
        public MessageApp UpdateOpcionesSist(ApiOpcionesSist opcionesSist)
        {
            MessageApp resultUpdate = null;
            if (ModelState.IsValid)
            {
                OpcionesSist opcionesSistUpdate = objMapper.CreateMapper().Map<OpcionesSist>(opcionesSist);
                resultUpdate = serviceOpcionesSist.UpdateOpcionesSist(opcionesSistUpdate);
            }
            return resultUpdate;
        }

        [HttpPost]
        public MessageApp DeleteOpcionesSist(string id)
        {
            MessageApp resultDelete = null;
            OpcionesSist opcionesSistDelete = serviceOpcionesSist.GetOpcionesSist(id);
            if (opcionesSistDelete != null)
            {
                resultDelete = serviceOpcionesSist.DeleteOpcionesSist(id);
            }

            return resultDelete;
        }

    }
}
