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
    public class PermisosRolController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServicePermisosRol servicePermisosRol;

        public PermisosRolController()
        {
            servicePermisosRol = new ServicePermisosRol();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new OpcionesSistProfile());
            profileList.Add(new MOpcionesSistProfile());
            profileList.Add(new RolProfile());
            profileList.Add(new MRolProfile());
            profileList.Add(new PermisosRolProfile());
            profileList.Add(new MPermisosRolProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }
    
    
        public JsonResult<List<ApiPermisosRol>> GetPermisosRoles()
        {
            List<PermisosRol> permisosRolesLista = servicePermisosRol.GetPermisosRoles();
            List<ApiPermisosRol> permisosRoles = objMapper.CreateMapper().Map<List<ApiPermisosRol>>(permisosRolesLista);
            return Json<List<ApiPermisosRol>>(permisosRoles);
        }

        public JsonResult<ApiPermisosRol> GetPermisosRol(string id)
        {
            PermisosRol permisosRolLista = servicePermisosRol.GetPermisosRol(id);
            ApiPermisosRol permisosRol = objMapper.CreateMapper().Map<ApiPermisosRol>(permisosRolLista);
            return Json<ApiPermisosRol>(permisosRol);
        }

        [HttpPost]
        public HttpResponseMessage InsertPermisosRol(ApiPermisosRol permisosRolNew)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                PermisosRol permisosRolInsert = objMapper.CreateMapper().Map<PermisosRol>(permisosRolNew);
                result = servicePermisosRol.InsertPermisosRol(permisosRolInsert);
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
        public HttpResponseMessage UpdatePermisosRol(ApiPermisosRol permisosRolUpd)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                PermisosRol permisosRolUpdate = objMapper.CreateMapper().Map<PermisosRol>(permisosRolUpd);
                result = servicePermisosRol.UpdatePermisosRol(permisosRolUpdate);
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
        public HttpResponseMessage DeletePermisosRol(string id)
        {
            MessageApp result = null;
            result = servicePermisosRol.DeletePermisosRol(id);

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
