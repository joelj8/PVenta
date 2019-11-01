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
    public class ServiceErrorList
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceErrorList()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<ErrorList> GetErrorLists()
        {
            List<ErrorList> result = null;
            try
            {
                result = _dbcontext.ErrorLists.Where(x => !x.Inactivo).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public ErrorList GetErrorList(string id)
        {
            ErrorList result = null;
            try
            {
                result = _dbcontext.ErrorLists.FirstOrDefault(x => !x.Inactivo && x.ID.Equals(id));
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public ErrorList GetErrorListByCodigo(string id)
        {
            ErrorList result = null;
            try
            {
                result = _dbcontext.ErrorLists.FirstOrDefault(x => !x.Inactivo && x.Codigo.Equals(id));
            }
            catch (Exception ex)
            {
                // Registrar en el log de errores
            }

            return result;
        }

        public MessageApp InsertErrorList(ErrorList errorListNew)
        {
            MessageApp result = null;
            List<ErrorList> listErrorListByCodigo = findErrorListMsgError(errorListNew);
            if (listErrorListByCodigo != null && listErrorListByCodigo.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    errorListNew.ID = newId.ToString();
                    _dbcontext.ErrorLists.Add(errorListNew);
                    _dbcontext.SaveChanges();
                    result = new MessageApp(GetErrorListByCodigo("RS00001"));
                }
                catch (Exception ex)
                {
                    result = new MessageApp(GetErrorListByCodigo("ER00001"));
                    // Registrar en el log de Errores
                }
            }
            else
            {
                result = new MessageApp(GetErrorListByCodigo("EL00002"));
            }
                
            
            return result;
        }

        public MessageApp UpdateErrorList(ErrorList errorListUpd)
        {
            MessageApp result = null ;
            List<ErrorList> listErrorListByCodigo = findErrorListMsgError(errorListUpd);
            if (listErrorListByCodigo != null && listErrorListByCodigo.Count == 0)
            {
                try
                {
                    ErrorList errorListUpdate = GetErrorList(errorListUpd.ID);
                    if (errorListUpdate != null)
                    {
                        errorListUpdate.Codigo = errorListUpd.Codigo;
                        errorListUpdate.MsgError = errorListUpd.MsgError;
                        _dbcontext.Entry(errorListUpdate).State = System.Data.Entity.EntityState.Modified;
                        _dbcontext.SaveChanges();
                        result = new MessageApp(GetErrorListByCodigo("RS00002"));
                    }
                    else
                    {
                        result = new MessageApp(GetErrorListByCodigo("EL00001"));
                    }
                }
                catch (Exception ex)
                {
                    result = new MessageApp(GetErrorListByCodigo("ER00002"));
                    // Registrar en el log de Errores
                }
            } 
            else
            {
                result = new MessageApp(GetErrorListByCodigo("EL00002"));
            }

            return result;
        }

        public MessageApp DeleteErrorList(string id)
        {
            MessageApp result = null;
            try
            {
                ErrorList errorListDelete = GetErrorList(id);
                if(errorListDelete != null)
                {
                    errorListDelete.Inactivo = true;
                    _dbcontext.Entry(errorListDelete).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = new MessageApp(GetErrorListByCodigo("RS00003"));
                }
                else
                {
                    result = new MessageApp(GetErrorListByCodigo("EL00001"));
                }
            }
            catch (Exception ex)
            {
                result = new MessageApp(GetErrorListByCodigo("ER00003"));
                // Registrar en el log de Errores
            }

            return result;
        }

        public List<ErrorList> findErrorListMsgError(ErrorList errorList)
        {
            List<ErrorList> errorListsList = null;
            try
            {
                errorListsList = _dbcontext.ErrorLists.Where(x => !x.Inactivo && x.ID != errorList.ID &&
                                                             (x.Codigo.Trim().Equals(errorList.Codigo.Trim()) ||
                                                             x.MsgError.Trim().Equals(errorList.MsgError.Trim()))).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
                
            }

            return errorListsList;
        }

    }
}
