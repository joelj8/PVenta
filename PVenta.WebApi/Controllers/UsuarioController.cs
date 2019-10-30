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
    public class UsuarioController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceUsuario serviceUsuario;

        public UsuarioController()
        {
            serviceUsuario = new ServiceUsuario();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new LogEventoProfile());
            profileList.Add(new MLogEventoProfile());
            profileList.Add(new UsuarioProfile());
            profileList.Add(new MUsuarioProfile());
            profileList.Add(new RolProfile());
            profileList.Add(new MRolProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiUsuario>> GetUsuarios()
        {
            List<Usuario> usuariosLista = serviceUsuario.GetUsuarios();
            List<ApiUsuario> usuarios = objMapper.CreateMapper().Map<List<ApiUsuario>>(usuariosLista);
            return Json<List<ApiUsuario>>(usuarios);
        }

        public JsonResult<ApiUsuario> GetUsuario(string id)
        {
            Usuario usuarioLista = serviceUsuario.GetUsuario(id);
            ApiUsuario usuario = objMapper.CreateMapper().Map<ApiUsuario>(usuarioLista);
            return Json<ApiUsuario>(usuario);
        }

        [HttpPost]
        public bool InsertUsuario(ApiUsuario usuario)
        {
            bool resultInsert = false;
            if (ModelState.IsValid) {
                Usuario usuarioInsert = objMapper.CreateMapper().Map<Usuario>(usuario);
                resultInsert = serviceUsuario.InsertUsuario(usuarioInsert);
            }

                return resultInsert;
        }

        [HttpPost]
        public bool UpdateUsuario(ApiUsuario usuario)
        {
            bool resultUdpdate = false;

            if (ModelState.IsValid)
            {
                Usuario usuarioUpdate = objMapper.CreateMapper().Map<Usuario>(usuario);
                resultUdpdate = serviceUsuario.UpdateUsuario(usuarioUpdate);
            }

            return resultUdpdate;
        }

        [HttpPost]
        public bool DeleteUsuario(string id)
        {
            bool resultDelete = false;
            Usuario usuarioDelete = serviceUsuario.GetUsuario(id);
            if (usuarioDelete != null)
            {
                resultDelete = serviceUsuario.DeleteUsuario(id);
            }

            return resultDelete;
        }
    }
}
