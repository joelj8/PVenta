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
    public class ServiceOpcionesSist
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceOpcionesSist()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<OpcionesSist> GetOpcionesSists()
        {
            var result = _dbcontext.OpcionesSists.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public OpcionesSist GetOpcionesSist(string id)
        {
            var result = _dbcontext.OpcionesSists.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public MessageApp InsertOpcionesSist(OpcionesSist opcionesSistNew)
        {
            MessageApp result = null;
            List<OpcionesSist> listaOpcionesSistByDescripcion = findOpcionesSist(opcionesSistNew);
            if (listaOpcionesSistByDescripcion != null && listaOpcionesSistByDescripcion.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    opcionesSistNew.ID = newId.ToString();
                    _dbcontext.OpcionesSists.Add(opcionesSistNew);
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
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
            
            return result;
        }

        public MessageApp UpdateOpcionesSist(OpcionesSist opcionesSistUpd)
        {
            MessageApp result = null;
            List<OpcionesSist> listaOpcionesSistByDescripcion = findOpcionesSist(opcionesSistUpd);
            if (listaOpcionesSistByDescripcion != null && listaOpcionesSistByDescripcion.Count == 0)
            {
                try
                {
                    OpcionesSist opcionesSistUpdate = GetOpcionesSist(opcionesSistUpd.ID);
                    if (opcionesSistUpdate != null)
                    {
                        opcionesSistUpdate.Codigo = opcionesSistUpd.Codigo;
                        opcionesSistUpdate.Descripcion = opcionesSistUpd.Descripcion;
                        _dbcontext.Entry(opcionesSistUpdate).State = System.Data.Entity.EntityState.Modified;
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
                    // Registrar en el log de Errores
                }
            } 
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }

            return result;
        }

        public MessageApp DeleteOpcionesSist(string id)
        {
            MessageApp result = null;
            try
            {
                OpcionesSist opcionesSistDelete = GetOpcionesSist(id);
                if (opcionesSistDelete != null)
                {
                    opcionesSistDelete.Inactivo = true;
                    _dbcontext.Entry(opcionesSistDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(ServiceEventApp.GetEventByCode("RS00003"));
                } 
                else
                {
                    result = new MessageApp(ServiceEventApp.GetEventByCode("EL00001"));
                }
            }
            catch (Exception)
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("ER00003"));
                // Registrar en el log de Errores
            }

            return result;
        }

        public List<OpcionesSist> findOpcionesSist(OpcionesSist findOpcionesSist)
        {
            List<OpcionesSist> opcionesSistLista = null;
            try
            {
                opcionesSistLista = _dbcontext.OpcionesSists.Where(x => !x.Inactivo && x.ID != findOpcionesSist.ID &&
                                                                (x.Descripcion.Equals(findOpcionesSist.Descripcion) ||
                                                                 x.Codigo.Equals(findOpcionesSist.Codigo))).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return opcionesSistLista;
        }


    }
}
