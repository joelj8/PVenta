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
        public MessageApp InsertProducto(ApiProducto producto)
        {
            MessageApp resultInsert = null;
            if (ModelState.IsValid)
            {
                Producto productoInsert = objMapper.CreateMapper().Map<Producto>(producto);
                resultInsert = serviceProducto.InsertProducto(productoInsert);
            }
            return resultInsert;
        }

        [HttpPost]
        public MessageApp UpdateProducto(ApiProducto producto)
        {
            MessageApp resultUpdate = null;
            if (ModelState.IsValid)
            {
                Producto productoUpdate = objMapper.CreateMapper().Map<Producto>(producto);
                resultUpdate = serviceProducto.UpdateProducto(productoUpdate);
            }
            return resultUpdate;
        }

        [HttpPost]
        public MessageApp DeleteProducto(string id )
        {
            MessageApp resultInsert = null;
            resultInsert = serviceProducto.DeleteProducto(id);
            return resultInsert;
        }
    }
}
