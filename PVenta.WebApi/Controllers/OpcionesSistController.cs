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
        public HttpResponseMessage InsertOpcionesSist(ApiOpcionesSist opcionesSist)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                OpcionesSist opcionesSistInsert = objMapper.CreateMapper().Map<OpcionesSist>(opcionesSist);
                result = serviceOpcionesSist.InsertOpcionesSist(opcionesSistInsert);
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
        public HttpResponseMessage UpdateOpcionesSist(ApiOpcionesSist opcionesSist)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                OpcionesSist opcionesSistUpdate = objMapper.CreateMapper().Map<OpcionesSist>(opcionesSist);
                result = serviceOpcionesSist.UpdateOpcionesSist(opcionesSistUpdate);
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
        public HttpResponseMessage DeleteOpcionesSist(string id)
        {
            MessageApp result = null;

            result = serviceOpcionesSist.DeleteOpcionesSist(id);


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
