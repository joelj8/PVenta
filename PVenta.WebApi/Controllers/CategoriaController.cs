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
        public bool InsertCategoria(ApiCategoria categoria)
        {
            bool resultInsert = false;
            if (ModelState.IsValid)
            {
                Categoria categoriaInsert = objMapper.CreateMapper().Map<Categoria>(categoria);
                resultInsert = serviceCategoria.InsertCategoria(categoriaInsert);
            }
            return resultInsert;
        }


        [HttpPost]
        public bool UpdateCategoria(ApiCategoria categoria)
        {
            bool resultUpdate = false;
            if (ModelState.IsValid)
            {
                Categoria categoriaUpdate = objMapper.CreateMapper().Map<Categoria>(categoria);
                resultUpdate = serviceCategoria.UpdateCategoria(categoriaUpdate);
            }
            return resultUpdate;
        }

        [HttpPost]
        public bool DeleteCategoria(string id)
        {
            bool resultDelete = false;
            Categoria categoriaDelete = serviceCategoria.GetCategoria(id);

            if (categoriaDelete != null)
            {
                resultDelete = serviceCategoria.DeleteCategoria(id);
            }
            return resultDelete;
        }




    }
}
