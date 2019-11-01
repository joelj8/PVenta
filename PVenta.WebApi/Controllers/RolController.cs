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
    public class RolController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceRol serviceRol;

        public RolController()
        {
            serviceRol = new ServiceRol();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new LogEventoProfile());
            profileList.Add(new MLogEventoProfile());
            profileList.Add(new UsuarioProfile());
            profileList.Add(new MUsuarioProfile());
            profileList.Add(new RolProfile());
            profileList.Add(new MRolProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiRol>> GetRoles()
        {
            List<Rol> rolesLista = serviceRol.GetRoles();
            List<ApiRol> roles = objMapper.CreateMapper().Map<List<ApiRol>>(rolesLista);
            return Json<List<ApiRol>>(roles);
        }

        public JsonResult<ApiRol> GetRol(string id)
        {
            Rol rolLista = serviceRol.GetRol(id);
            ApiRol rol = objMapper.CreateMapper().Map<ApiRol>(rolLista);
            return Json<ApiRol>(rol);
        }

        [HttpPost]
        public MessageApp InsertRol(ApiRol rol)
        {
            MessageApp resultinsert = null;
            if (ModelState.IsValid)
            {
                Rol rolInsert = objMapper.CreateMapper().Map<Rol>(rol);
                resultinsert = serviceRol.InsertRol(rolInsert);
            }
            return resultinsert;
        }

        [HttpPost]
        public bool UpdateRol(ApiRol rol)
        {
            bool resultUpdate = false;
            if (ModelState.IsValid)
            {
                Rol rolUpdate = objMapper.CreateMapper().Map<Rol>(rol);
                resultUpdate = serviceRol.UpdateRol(rolUpdate);
            }

            return resultUpdate;

        }

        [HttpPost]
        public bool DeleteRol(string id)
        {
            bool resultDelete = false;
            Rol rolDelete = serviceRol.GetRol(id);
            if (rolDelete != null)
            {
                resultDelete = serviceRol.DeleteRol(id);
            }
            
            return resultDelete;
        }

    }
}
