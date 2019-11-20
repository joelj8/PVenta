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
    public class ProductoController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceProducto serviceProducto;
        public ProductoController()
        {
            serviceProducto = new ServiceProducto();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new ProductoProfile());
            profileList.Add(new MProductoProfile());
            profileList.Add(new CategoriaProfile());
            profileList.Add(new MCategoriaProfile());

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }


        public JsonResult<List<ApiProducto>> GetProductos()
        {
            List<Producto> productosLista = serviceProducto.GetProductos();
            List<ApiProducto> productos = objMapper.CreateMapper().Map<List<ApiProducto>>(productosLista);
            return Json<List<ApiProducto>>(productos);
        }

        public JsonResult<ApiProducto> GetProducto(string id)
        {
            Producto productoLista = serviceProducto.GetProducto(id);
            ApiProducto producto = objMapper.CreateMapper().Map<ApiProducto>(productoLista);
            return Json<ApiProducto>(producto);
        }

        [HttpPost]
        public HttpResponseMessage InsertProducto(ApiProducto producto)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Producto productoInsert = objMapper.CreateMapper().Map<Producto>(producto);
                result = serviceProducto.InsertProducto(productoInsert);
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
        public HttpResponseMessage UpdateProducto(ApiProducto producto)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                Producto productoUpdate = objMapper.CreateMapper().Map<Producto>(producto);
                result = serviceProducto.UpdateProducto(productoUpdate);
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
        public HttpResponseMessage DeleteProducto(string id )
        {
            MessageApp result = null;
            result = serviceProducto.DeleteProducto(id);

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
