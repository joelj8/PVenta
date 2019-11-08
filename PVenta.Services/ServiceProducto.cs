﻿using PVenta.DAL;
using PVenta.Models.Model;
using PVenta.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceProducto
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceProducto()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Producto> GetProductos()
        {
            var result = _dbcontext.Productos.Include("Categoria").Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Producto GetProducto(string id)
        {
            var result = _dbcontext.Productos.Include("Categoria").FirstOrDefault(x => !x.Inactivo && x.ID == id);
            return result;
        }

        public MessageApp InsertProducto(Producto productoNew)
        {
            MessageApp resultInsert = null;
            List<Producto> listProductoByName = findProductoName(productoNew);
            if (listProductoByName != null && listProductoByName.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    productoNew.ID = newId.ToString();
                    _dbcontext.Productos.Add(productoNew);
                    _dbcontext.SaveChanges();
                    resultInsert = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                }
                catch (Exception ex)
                {
                    resultInsert = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                    // Registrar en el log de errores
                }
            }
            else
            {
                resultInsert = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return resultInsert;
        }

        public MessageApp UpdateProducto(Producto productoUpd)
        {
            MessageApp result = null;
            List<Producto> listProductoByName = findProductoName(productoUpd);
            if (listProductoByName != null && listProductoByName.Count == 0)
            {
                try
                {
                    Producto productoUpdate = GetProducto(productoUpd.ID);
                    if (productoUpdate != null)
                    {
                        productoUpdate.Nombre = productoUpd.Nombre;
                        productoUpdate.NombreCorto = productoUpd.NombreCorto;
                        productoUpdate.Precio = productoUpd.Precio;
                        productoUpdate.CategoriaId = productoUpd.CategoriaId;
                        productoUpdate.esAdicional = productoUpd.esAdicional;
                        productoUpdate.ImpComanda = productoUpd.ImpComanda;
                        _dbcontext.Entry(productoUpdate).State = System.Data.Entity.EntityState.Modified;
                        _dbcontext.SaveChanges();
                        result = new MessageApp(ServiceEventApp.GetEventByCode("RS00002"));
                    }
                    else
                    {
                        result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                    }
                }
                catch (Exception)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00002"));
                    // Registrar en el log de errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
           
            return result;
        }

        public MessageApp DeleteProducto(string id)
        {
            MessageApp result = null;
            try
            {
                Producto productoDelete = GetProducto(id);
                if (productoDelete != null)
                {
                    productoDelete.Inactivo = true;
                    _dbcontext.Entry(productoDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00003"));
                } 
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00003"));
                // Registrar en el log de errores
            }

            return result;
        }

        private List<Producto> findProductoName(Producto productoFind)
        {
            List<Producto> resultList = null;
            try
            {
                resultList = _dbcontext.Productos.Where(x => !x.Inactivo && x.ID != productoFind.ID &&
                                                    (x.Nombre.Equals(productoFind.Nombre) ||
                                                     x.NombreCorto.Equals(productoFind.NombreCorto))).ToList();
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return resultList;
        }
    }
}
