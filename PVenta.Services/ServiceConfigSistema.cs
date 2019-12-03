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
    public class ServiceConfigSistema
    {
        private readonly DBPVentaContext _dbcontext;
        public ServiceConfigSistema()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<ConfigSistema> GetConfigSistemas()
        {
            List<ConfigSistema> result = null;
            try
            {
                result = _dbcontext.ConfigSistemas.Include("InfoDigitals")
                         .Where(x => !x.Inactivo).ToList();
                foreach (ConfigSistema confSistEvalua in result)
                {
                    // Preparar la lista de InfoDigital con los registros que no estan inactivos
                    List<InfoDigital> listDetail = (from confDet in confSistEvalua.InfoDigitals
                                                    where !confDet.Inactivo
                                                    select confDet).ToList();

                    // Reasignar la lista de InfoDigitals con la lista de previamente creada
                    confSistEvalua.InfoDigitals = listDetail;
                }

            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public ConfigSistema GetConfigSistema(string id)
        {
            ConfigSistema result = null;
            try
            {
                result = GetConfigSistemaORG(id);

                // Preparar la lista de InfoDigital con los registros que no estan inactivos
                List<InfoDigital> listDetail = (from confDet in result.InfoDigitals
                                                where !confDet.Inactivo
                                                select confDet).ToList();

                // Reasignar la lista de InfoDigitals con la lista de previamente creada
                result.InfoDigitals = listDetail;

            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public ConfigSistema GetConfigSistemaORG(string id)
        {
            ConfigSistema result = null;
            try
            {
                result = _dbcontext.ConfigSistemas.Include("InfoDigitals")
                    .FirstOrDefault(x => !x.Inactivo && x.ID == id);
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public MessageApp InsertConfigSistema(ConfigSistema configSistemaNew)
        {
            MessageApp result = null;
            List<ConfigSistema> listConfigSistemas = GetConfigSistemas();
            List<ConfigSistema> listConfigSistemasByNombre = findConfigSistemasNombre(configSistemaNew);
            if ((listConfigSistemas != null && listConfigSistemas.Count == 0) && (listConfigSistemasByNombre != null && listConfigSistemasByNombre.Count == 0))
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    Guid newRelacionId = Guid.NewGuid();
                    configSistemaNew.ID = newId.ToString();
                    configSistemaNew.RelacionID = newRelacionId.ToString();
                    foreach(InfoDigital infDig in configSistemaNew.InfoDigitals)
                    {
                        Guid newInfoDigitalId = Guid.NewGuid();
                        infDig.ID = newInfoDigitalId.ToString();
                        infDig.RelacionID = newRelacionId.ToString();
                    }

                    _dbcontext.ConfigSistemas.Add(configSistemaNew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00001"));
                }
                catch (Exception ex)
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                    // Registrar en el log de Errores
                }
            }
            else
            {
                if (listConfigSistemas == null || listConfigSistemas.Count != 0)
                {
                    // Existe una Compañia Registrada
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00003"));
                } 
                else if (listConfigSistemasByNombre == null || listConfigSistemasByNombre.Count != 0)
                {
                    
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
                }
            }

            return result;
        }

        public MessageApp UpdateConfigSistema(ConfigSistema configSistemaUpd)
        {
            MessageApp result = null;
            List<ConfigSistema> listConfigSistemasByNombre = findConfigSistemasNombre(configSistemaUpd);
            if (listConfigSistemasByNombre != null && listConfigSistemasByNombre.Count == 0)
            {
                try
                {
                    ConfigSistema configSistemaUpdate = GetConfigSistemaORG(configSistemaUpd.ID);
                    if (configSistemaUpdate != null)
                    {
                        configSistemaUpdate.CalcITBIS = configSistemaUpd.CalcITBIS;
                        configSistemaUpdate.PorcITBIS = configSistemaUpd.PorcITBIS;
                        configSistemaUpdate.PorcServicio = configSistemaUpd.PorcServicio;
                        configSistemaUpdate.CodigoSegInactivar = configSistemaUpd.CodigoSegInactivar;
                        configSistemaUpdate.ComprobanteFiscal = configSistemaUpd.ComprobanteFiscal;
                        configSistemaUpdate.Direccion = configSistemaUpd.Direccion;
                        configSistemaUpdate.ImprimeComandaAuto = configSistemaUpd.ImprimeComandaAuto;
                        configSistemaUpdate.ImprimeOrdenAuto = configSistemaUpd.ImprimeOrdenAuto;
                        configSistemaUpdate.ImprimeFacturaAuto = configSistemaUpd.ImprimeFacturaAuto;
                        configSistemaUpdate.MensajeFactura = configSistemaUpd.MensajeFactura;
                        configSistemaUpdate.MensajeOrden = configSistemaUpd.MensajeOrden;
                        configSistemaUpdate.NumComprobanteFiscal = configSistemaUpd.NumComprobanteFiscal;
                        configSistemaUpdate.Telefono = configSistemaUpd.Telefono;

                        actDetalleInfDigital(configSistemaUpd, configSistemaUpdate);
                        addDetalleNewInfoDigital(configSistemaUpd, configSistemaUpdate);

                        _dbcontext.Entry(configSistemaUpdate).State = System.Data.Entity.EntityState.Modified;
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
                    result = new MessageApp(ServiceEventApp.GetEventByCode("ER00001"));
                    // Registrar en el log de Errores
                }
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return result;
        }

        public MessageApp DeleteConfigSistema(string id)
        {
            MessageApp result = null;
            try
            {
                ConfigSistema configSistemaDelete = GetConfigSistemaORG(id);
                if (configSistemaDelete != null)
                {
                    configSistemaDelete.Inactivo = true;
                    _dbcontext.Entry(configSistemaDelete).State = System.Data.Entity.EntityState.Modified;
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
                // Registrar en el log de Errores
            }

            return result;
        }

        private List<ConfigSistema> findConfigSistemasNombre(ConfigSistema configSistemaFind)
        {
            List<ConfigSistema> configSistemaLista = null;
            try
            {
                configSistemaLista = _dbcontext.ConfigSistemas
                                       .Where(x => !x.Inactivo &&
                                       x.ID != configSistemaFind.ID &&
                                       (x.NombreComercial.ToLower().Equals(configSistemaFind.NombreComercial.ToLower()) ||
                                        x.NombreNeg.ToLower().Equals(configSistemaFind.NombreNeg.ToLower()) ||
                                        x.RNC.ToLower().Equals(configSistemaFind.RNC.ToLower()))).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }
            return configSistemaLista;
        }

        private void addDetalleNewInfoDigital(ConfigSistema configSistemaUpd, ConfigSistema configSistemaUpdate)
        {

            foreach(InfoDigital infDigAdd in configSistemaUpd.InfoDigitals)
            {
                if (infDigAdd.ID == null || infDigAdd.ID == string.Empty)
                {
                    InfoDigital addInfDitalUpd = new InfoDigital();
                    Guid newInfoDigitalId = Guid.NewGuid();

                    addInfDitalUpd.ID = newInfoDigitalId.ToString();
                    addInfDitalUpd.Descripcion = infDigAdd.Descripcion;
                    addInfDitalUpd.TypeInfoID = infDigAdd.TypeInfoID;
                    addInfDitalUpd.RelacionID = configSistemaUpd.RelacionID;
                    configSistemaUpdate.InfoDigitals.Add(addInfDitalUpd);
                }
            }

        }

        private void actDetalleInfDigital(ConfigSistema configSistemaUpd, ConfigSistema configSistemaUpdate)
        {
            bool regUpdated = false;
            foreach (InfoDigital updInfoDig in configSistemaUpdate.InfoDigitals)
            {
                regUpdated = false;
                foreach (InfoDigital infDig in configSistemaUpd.InfoDigitals)
                {
                    if (infDig.ID == updInfoDig.ID)
                    {
                        updInfoDig.TypeInfoID = infDig.TypeInfoID;
                        updInfoDig.Descripcion = infDig.Descripcion;
                        regUpdated = true;
                    }
                }

                // Registro excluido
                if (!regUpdated)
                {
                    updInfoDig.Inactivo = true;
                }
            }
        }
    }
}
