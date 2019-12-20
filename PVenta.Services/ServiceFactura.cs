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
    public class ServiceFactura
    {
        private readonly DBPVentaContext _dbcontext;
        public ServiceFactura()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<FacturaHeader> GetFacturas()
        {
            List<FacturaHeader> result = null;
            try
            {
                result = _dbcontext.FacturaHeaders.Include("FacturaDetails")
                        .Include("FacturaPayments")
                        .Include("Mesa")
                        .Where(x => !x.Inactivo).ToList();

                foreach (FacturaHeader factEvalua in result)
                {
                    // Preparar la lista de FacturaDetail con los registros que no estan inactivos
                    List<FacturaDetail> listDetail = (from factDet in factEvalua.FacturaDetails
                                                    where !factDet.Inactivo
                                                    select factDet).ToList();

                    // Preparar la lista de FacturaPayment con los registros que no estan inactivos
                    List<FacturaPayment> listPayment = (from factPay in factEvalua.FacturaPayments
                                                      where !factPay.Inactivo
                                                      select factPay).ToList();

                    // Reasignar la lista de FacturaDetails y FacturaPayments con las listas de previamente creadas
                    factEvalua.FacturaDetails = listDetail;
                    factEvalua.FacturaPayments = listPayment;
                }
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public List<FacturaHeader> GetFacturasByOrder(string id)
        {
            List<FacturaHeader> result = null;
            try
            {
                result = _dbcontext.FacturaHeaders.Include("FacturaDetails")
                        .Include("FacturaPayments")
                        .Include("Mesa")
                        .Where(x => !x.Inactivo && x.OrderHID == id).ToList();

                foreach (FacturaHeader factEvalua in result)
                {
                    // Preparar la lista de FacturaDetail con los registros que no estan inactivos
                    List<FacturaDetail> listDetail = (from factDet in factEvalua.FacturaDetails
                                                      where !factDet.Inactivo
                                                      select factDet).ToList();

                    // Preparar la lista de FacturaPayment con los registros que no estan inactivos
                    List<FacturaPayment> listPayment = (from factPay in factEvalua.FacturaPayments
                                                        where !factPay.Inactivo
                                                        select factPay).ToList();

                    // Reasignar la lista de FacturaDetails y FacturaPayments con las listas de previamente creadas
                    factEvalua.FacturaDetails = listDetail;
                    factEvalua.FacturaPayments = listPayment;
                }
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public List<FacturaHeader> GetFacturasByFecha(FechaRango paramFechRango)
        {
            List<FacturaHeader> result = null;
            try
            {
                result = _dbcontext.FacturaHeaders.Include("FacturaDetails")
                        .Include("FacturaPayments")
                        .Include("Mesa")
                        .Where(x => !x.Inactivo && x.Fecha >= paramFechRango.FechaInicio &&
                               x.Fecha <= paramFechRango.FechaFin).ToList();

                foreach (FacturaHeader factEvalua in result)
                {
                    // Preparar la lista de FacturaDetail con los registros que no estan inactivos
                    List<FacturaDetail> listDetail = (from factDet in factEvalua.FacturaDetails
                                                      where !factDet.Inactivo
                                                      select factDet).ToList();

                    // Preparar la lista de FacturaPayment con los registros que no estan inactivos
                    List<FacturaPayment> listPayment = (from factPay in factEvalua.FacturaPayments
                                                        where !factPay.Inactivo
                                                        select factPay).ToList();

                    // Reasignar la lista de FacturaDetails y FacturaPayments con las listas de previamente creadas
                    factEvalua.FacturaDetails = listDetail;
                    factEvalua.FacturaPayments = listPayment;
                }
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public FacturaHeader GetFactura(string id)
        {
            FacturaHeader result = null;
            try
            {
                result = GetFacturaHeaderORG(id);
                // Preparar la lista de FacturaDetail con los registros que no estan inactivos
                List<FacturaDetail> listDetail = (from factDet in result.FacturaDetails
                                                  where !factDet.Inactivo
                                                  select factDet).ToList();

                // Preparar la lista de FacturaPayment con los registros que no estan inactivos
                List<FacturaPayment> listPayment = (from factPay in result.FacturaPayments
                                                    where !factPay.Inactivo
                                                    select factPay).ToList();

                // Reasignar la lista de FacturaDetails y FacturaPayments con las listas de previamente creadas
                result.FacturaDetails = listDetail;
                result.FacturaPayments = listPayment;

            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }
            return result;
        }

        public FacturaHeader GetFacturaHeaderORG(string id)
        {
            FacturaHeader result = null;
            try
            {
                result = _dbcontext.FacturaHeaders.Include("FacturaDetails")
                    .Include("FacturaPayments")
                    .Include("Mesa")
                    .FirstOrDefault(x => !x.Inactivo && x.ID.Contains(id));
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public MessageApp InsertFacturaHeader(FacturaHeader facturaHeader)
        {
            MessageApp result = null;

            try
            {
                string newId = ValidateID(facturaHeader.ID);
                Guid newIdDetail;
                Guid newIdPayment;
                facturaHeader.ID = newId.ToString();
                facturaHeader.FechaRegistro = System.DateTime.Now;
                facturaHeader.NumFactura = 0;
                
                foreach (FacturaDetail od in facturaHeader.FacturaDetails)
                {
                    newIdDetail = Guid.NewGuid();
                    od.ID = newIdDetail.ToString();
                    od.FacturaHID = newId.ToString();
                }

                foreach(FacturaPayment op in facturaHeader.FacturaPayments)
                {
                    newIdPayment = Guid.NewGuid();
                    op.ID = newIdPayment.ToString();
                    op.FacturaHID = newId.ToString();
                }

                _dbcontext.FacturaHeaders.Add(facturaHeader);
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

        private string ValidateID(string id)
        {
            string valIDReturn = id;
            FacturaHeader orderIDCreated = GetFactura(id);
            if (orderIDCreated != null)
            {
                valIDReturn = Guid.NewGuid().ToString();
            }
            return valIDReturn;
        }

        public MessageApp UpdateFacturaHeader(FacturaHeader facturaHeader)
        {
            MessageApp result = null;

            try
            {
                FacturaHeader facturaHeaderUpdate = GetFacturaHeaderORG(facturaHeader.ID);
                if (facturaHeaderUpdate != null)
                {
                    string updatedHeaderId = facturaHeader.ID;
                    string newIdDetail;
                    facturaHeaderUpdate.ClientePrincipal = facturaHeader.ClientePrincipal;
                    facturaHeaderUpdate.DescMonto = facturaHeader.DescMonto;
                    facturaHeaderUpdate.DescPorc = facturaHeader.DescPorc;
                    facturaHeaderUpdate.Fecha = facturaHeader.Fecha;
                    facturaHeaderUpdate.Impreso = facturaHeader.Impreso;
                    facturaHeaderUpdate.Itbis = facturaHeader.Itbis;
                    facturaHeaderUpdate.ItbisPorc = facturaHeader.ItbisPorc;
                    facturaHeaderUpdate.Servicio = facturaHeader.Servicio;
                    facturaHeaderUpdate.ServicioPorc = facturaHeader.ServicioPorc;
                    facturaHeaderUpdate.MesaId = facturaHeader.MesaId;

                    #region FacturaDetail
                    foreach (FacturaDetail factExist in facturaHeaderUpdate.FacturaDetails)
                    {
                        string idUpdate = factExist.ID;
                        bool regUpdated = false;
                        foreach (FacturaDetail facturaData in facturaHeader.FacturaDetails)
                        {
                            // En caso de algun cambio
                            if (facturaData.ID.Equals(idUpdate) && !facturaData.Inactivo)
                            {
                                factExist.Cantidad = facturaData.Cantidad;
                                factExist.ClientePedido = facturaData.ClientePedido;
                                factExist.Precio = facturaData.Precio;
                                factExist.ImpComanda = facturaData.ImpComanda;
                                factExist.ProductoID = facturaData.ProductoID;
                                factExist.Orden = facturaData.Orden;
                                regUpdated = true;
                            }
                        }

                        if (!regUpdated)
                        {
                            // Inactivando el registro que no fue encontrado y/o eliminados
                            factExist.Inactivo = true;
                        }

                    }

                    // Adding New Register for FacturaDetail
                    foreach (FacturaDetail facturaNew in facturaHeader.FacturaDetails)
                    {
                        string idNew = facturaNew.ID;
                        // En caso de un nuevo registro
                        if (idNew == null || idNew == string.Empty)
                        {
                            newIdDetail = Guid.NewGuid().ToString();
                            facturaNew.ID = newIdDetail;
                            facturaNew.FacturaHID = updatedHeaderId;
                            facturaHeaderUpdate.FacturaDetails.Add(facturaNew);
                        }
                    }
                    #endregion

                    #region FacturaPayment
                    foreach (FacturaPayment factExist in facturaHeaderUpdate.FacturaPayments)
                    {
                        string idUpdate = factExist.ID;
                        bool regUpdated = false;
                        foreach (FacturaPayment facturaData in facturaHeader.FacturaPayments)
                        {
                            // En caso de algun cambio
                            if (facturaData.ID.Equals(idUpdate) && !facturaData.Inactivo)
                            {
                                factExist.FechaPago = facturaData.FechaPago;
                                factExist.MontoPago = facturaData.MontoPago;
                                factExist.MontoDevolver = facturaData.MontoDevolver;
                                factExist.FormaPagoId = facturaData.FormaPagoId;
                                factExist.InfoPago = facturaData.InfoPago;
                                regUpdated = true;
                            }
                        }

                        if (!regUpdated)
                        {
                            // Inactivando el registro que no fue encontrado y/o eliminados
                            factExist.Inactivo = true;
                        }

                    }

                    // Adding New Register for FacturaPayments
                    foreach (FacturaPayment facturaNew in facturaHeader.FacturaPayments)
                    {
                        string idNew = facturaNew.ID;
                        // En caso de un nuevo registro
                        if (idNew == null || idNew == string.Empty)
                        {
                            newIdDetail = Guid.NewGuid().ToString();
                            facturaNew.ID = newIdDetail;
                            facturaNew.FacturaHID = updatedHeaderId;
                            facturaHeaderUpdate.FacturaPayments.Add(facturaNew);
                        }
                    }
                    #endregion

                    _dbcontext.Entry(facturaHeaderUpdate).State = System.Data.Entity.EntityState.Modified;
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

        public MessageApp DeleteFacturaHeader(string id)
        {
            MessageApp result = null;

            try
            {
                FacturaHeader facturaHeaderDelete = GetFactura(id);
                if (facturaHeaderDelete != null)
                {
                    facturaHeaderDelete.Inactivo = true;

                    _dbcontext.Entry(facturaHeaderDelete).State = System.Data.Entity.EntityState.Modified;
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
