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
                foreach(OrderHeader ordEvalua in result)
                {
                    // Preparar la lista de OrderDetail con los registros que no estan inactivos
                    List<OrderDetail> listDetail = (from ordDet in ordEvalua.OrderDetails
                                                    where !ordDet.Inactivo
                                                    select ordDet).ToList();

                    // Reasignar la lista de OrderDetails con la lista de previamente creada
                    ordEvalua.OrderDetails = listDetail;
                }
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
                result = GetOrderHeaderORG(id);

                // Preparar la lista de OrderDetail con los registros que no estan inactivos
                List<OrderDetail> listDetail = (from ordDet in result.OrderDetails
                                                where !ordDet.Inactivo
                                                select ordDet).ToList();

                // Reasignar la lista de OrderDetails con la lista de previamente creada
                result.OrderDetails = listDetail;
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public OrderHeader GetOrderHeaderORG(string id)
        {

            OrderHeader result = null;

            try
            {
                result = _dbcontext.OrderHeaders.Include("OrderDetails").Include("Mesa")
                    .Where(x => !x.Inactivo && x.ID.Equals(id)).FirstOrDefault();
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
                orderHeader.NumOrden = 0;

                foreach(OrderDetail od in orderHeader.OrderDetails)
                {
                    newIdDetail = Guid.NewGuid();
                    od.ID = newIdDetail.ToString();
                    od.OrderHID = newId.ToString();
                }
                //_dbcontext.IsDbGenerated = true;
                
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
                OrderHeader orderHeaderUpdate = GetOrderHeaderORG(orderHeader.ID);
                if (orderHeaderUpdate != null)
                {
                    string updatedHeaderId = orderHeader.ID;
                    string newIdDetail;
                    orderHeaderUpdate.ClientePrincipal = orderHeader.ClientePrincipal;
                    orderHeaderUpdate.DescMonto = orderHeader.DescMonto;
                    orderHeaderUpdate.DescPorc = orderHeader.DescPorc;
                    orderHeaderUpdate.Fecha = orderHeader.Fecha;
                    orderHeaderUpdate.Impreso = orderHeader.Impreso;
                    orderHeaderUpdate.Itbis = orderHeader.Itbis;
                    orderHeaderUpdate.ItbisPorc = orderHeader.ItbisPorc;
                    orderHeaderUpdate.Servicio = orderHeader.Servicio;
                    orderHeaderUpdate.ServicioPorc = orderHeader.ServicioPorc;
                    orderHeaderUpdate.MesaId = orderHeader.MesaId;
                    
                    //orderHeaderUpdate.OrderDetails = orderHeader.OrderDetails;

                    foreach(OrderDetail ordExist in orderHeaderUpdate.OrderDetails)
                    {
                        string idUpdate = ordExist.ID;
                        bool regUpdated = false;
                        foreach(OrderDetail orderData in orderHeader.OrderDetails)
                        {
                            // En caso de algun cambio
                            if (orderData.ID.Equals(idUpdate) && !orderData.Inactivo)
                            {
                                ordExist.Cantidad = orderData.Cantidad;
                                ordExist.ClientePedido = orderData.ClientePedido;
                                ordExist.Precio = orderData.Precio;
                                ordExist.ImpComanda = orderData.ImpComanda;
                                ordExist.ProductoID = orderData.ProductoID;
                                ordExist.Orden = orderData.Orden;
                                regUpdated = true;
                            }
                        }

                        if (!regUpdated)
                        {
                            // Inactivando el registro que no fue encontrado y/o eliminados
                            ordExist.Inactivo = true;
                        }
                    
                    }

                    // Adding New Register for OrderDetail
                    foreach (OrderDetail orderNew in orderHeader.OrderDetails)
                    {
                        string idNew = orderNew.ID;
                        bool regExiste = orderHeaderUpdate.OrderDetails.Count(x => x.ID == idNew) > 0;
                        // En caso de un nuevo registro
                        if (!regExiste)
                        {
                            newIdDetail = Guid.NewGuid().ToString();
                            orderNew.ID = newIdDetail;
                            orderNew.OrderHID = updatedHeaderId;
                            orderHeaderUpdate.OrderDetails.Add(orderNew);
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
                OrderHeader orderHeaderDelete = GetOrderHeaderORG(id);
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
