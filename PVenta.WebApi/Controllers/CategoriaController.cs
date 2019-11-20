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
    public class CategoriaController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceCategoria serviceCategoria;

        public CategoriaController()
        {
            serviceCategoria = new ServiceCategoria();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new CategoriaProfile());
            profileList.Add(new MCategoriaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }

        public JsonResult<List<ApiCategoria>> GetCategorias()
        {
            List<Categoria> categoriasLista = serviceCategoria.GetCategorias();
            List<ApiCategoria> categorias = objMapper.CreateMapper().Map<List<ApiCategoria>>(categoriasLista);
            
            return Json<List<ApiCategoria>>(categorias);
        }

        public JsonResult<ApiCategoria> GetCategoria (string id)
        {
            Categoria categoriaLista = serviceCategoria.GetCategoria(id);
            ApiCategoria categoria = objMapper.CreateMapper().Map<ApiCategoria>(categoriaLista);

            return Json<ApiCategoria>(categoria);
        }

        [HttpPost]
        public HttpResponseMessage InsertCategoria(ApiCategoria categoria)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Categoria categoriaInsert = objMapper.CreateMapper().Map<Categoria>(categoria);
                result = serviceCategoria.InsertCategoria(categoriaInsert);
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
        public HttpResponseMessage UpdateCategoria(ApiCategoria categoria)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Categoria categoriaUpdate = objMapper.CreateMapper().Map<Categoria>(categoria);
                result = serviceCategoria.UpdateCategoria(categoriaUpdate);
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
        public HttpResponseMessage DeleteCategoria(string id)
        {
            MessageApp result = null;
            result = serviceCategoria.DeleteCategoria(id);

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
