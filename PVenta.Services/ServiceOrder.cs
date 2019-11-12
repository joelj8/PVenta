using PVenta.DAL;
using PVenta.Models.Model;
using PVenta.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceOrder
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceOrder()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<OrderHeader> GetOrderHeaders()
        {
            List<OrderHeader> result = null;
            try
            {
                result = _dbcontext.OrderHeaders.Include("OrderDetails").Include("Mesa").Where(x => !x.Inactivo).ToList();
                
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public OrderHeader GetOrderHeader(string id)
        {

            OrderHeader result = null;
            try
            {
                result = _dbcontext.OrderHeaders.Include("OrderDetails").Include("Mesa")
                    .Where(x => !x.Inactivo && x.ID.Equals(id)).FirstOrDefault();
                //result.OrderDetails = result.OrderDetails.Where(x => !x.Inactivo).ToList(); // Idea para el filtro
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }
    
        public MessageApp InsertOrderHeader(OrderHeader orderHeader)
        {
            MessageApp result = null;

            try
            {
                Guid newId = Guid.NewGuid();
                Guid newIdDetail;
                orderHeader.ID = newId.ToString();
                orderHeader.FechaRegistro = System.DateTime.Now;
                orderHeader.UserId = "4a123d40-fdc6-4723-b341-bb2cec1ef255";
                foreach(OrderDetail od in orderHeader.OrderDetails)
                {
                    newIdDetail = Guid.NewGuid();
                    od.ID = newIdDetail.ToString();
                    od.OrderHID = newId.ToString();
                }

                _dbcontext.OrderHeaders.Add(orderHeader);
                _dbcontext.SaveChanges();
                result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                // Registrar en el log de errores
            }
            
            return result;
        }

        public MessageApp UpdateOrderHeader(OrderHeader orderHeader)
        {
            MessageApp result = null;

            try
            {
                OrderHeader orderHeaderUpdate = GetOrderHeader(orderHeader.ID);
                if (orderHeaderUpdate != null)
                {
                    string newId = orderHeader.ID;
                    string newIdDetail;
                    orderHeaderUpdate.ClientePrincipal = orderHeader.ClientePrincipal;
                    orderHeaderUpdate.DescMonto = orderHeader.DescMonto;
                    orderHeaderUpdate.DescPorc = orderHeader.DescPorc;
                    orderHeaderUpdate.Fecha = orderHeader.Fecha;
                    orderHeaderUpdate.Impreso = orderHeader.Impreso;
                    orderHeaderUpdate.Itbis = orderHeader.Itbis;
                    orderHeaderUpdate.ItbisPorc = orderHeader.ItbisPorc;
                    orderHeaderUpdate.MesaId = orderHeader.MesaId;
                    //orderHeaderUpdate.OrderDetails = orderHeader.OrderDetails;

                    foreach(OrderDetail ordExist in orderHeaderUpdate.OrderDetails)
                    {
                        string idUpdate = ordExist.ID;
                        bool regUpdated = false;
                        foreach(OrderDetail orderData in orderHeader.OrderDetails)
                        {
                            // En caso de algun cambio
                            if (orderData.ID.Equals(idUpdate))
                            {
                                ordExist.Cantidad = orderData.Cantidad;
                                ordExist.ClientePedido = orderData.ClientePedido;
                                ordExist.Precio = orderData.Precio;
                                ordExist.ProductoID = orderData.ProductoID;
                                regUpdated = true;
                            }
                        }

                        if (!regUpdated)
                        {
                            // Borrando los registros eliminados
                            ordExist.Inactivo = true;
                        }

                        // En caso de un nuevo registro
                        if (idUpdate == null || idUpdate == string.Empty)
                        {
                            newIdDetail = Guid.NewGuid().ToString();
                            ordExist.ID = newIdDetail;
                        }
                    }

                    
                    
                    


                    _dbcontext.Entry(orderHeaderUpdate).State = System.Data.Entity.EntityState.Modified;
                    
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00002"));
                }
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
                
            }
            catch (Exception ex)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00002"));
                // Registrar en el log de errores
            }

            return result;
        }

        public MessageApp DeleteOrderHeader(string id)
        {
            MessageApp result = null;

            try
            {
                OrderHeader orderHeaderDelete = GetOrderHeader(id);
                if (orderHeaderDelete != null)
                {
                    orderHeaderDelete.Inactivo = true;

                    _dbcontext.Entry(orderHeaderDelete).State = System.Data.Entity.EntityState.Modified;
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

    }
}
