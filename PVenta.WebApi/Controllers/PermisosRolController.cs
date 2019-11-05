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
        public MessageApp InsertPermisosRol(ApiPermisosRol permisosRolNew)
        {
            MessageApp resultInsert = null;
            if (ModelState.IsValid)
            {
                PermisosRol permisosRolInsert = objMapper.CreateMapper().Map<PermisosRol>(permisosRolNew);
                resultInsert = servicePermisosRol.InsertPermisosRol(permisosRolInsert);
            }
            return resultInsert;
        }

        [HttpPost]
        public MessageApp UpdatePermisosRol(ApiPermisosRol permisosRolUpd)
        {
            MessageApp resultUpdate = null;
            if (ModelState.IsValid)
            {
                PermisosRol permisosRolUpdate = objMapper.CreateMapper().Map<PermisosRol>(permisosRolUpd);
                resultUpdate = servicePermisosRol.UpdatePermisosRol(permisosRolUpdate);
            }

            return resultUpdate;
        }

        [HttpPost]
        public MessageApp DeletePermisosRol(string id)
        {
            MessageApp resultDelete = null;
            resultDelete = servicePermisosRol.DeletePermisosRol(id);

            return resultDelete;
        }

    
    
    }
}
