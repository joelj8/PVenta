using PVenta.DAL;
using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceLogEvento
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceLogEvento()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<LogEvento> GetLogEventos()
        {
            var result = _dbcontext.LogEventos.Include("Usuario").ToList();
            return result;
        }

        public LogEvento GetLogEvento(string id)
        {
            var result = _dbcontext.LogEventos.Include("Usuario").Where(x => x.ID == id).FirstOrDefault();
            return result;
        }

        public bool InsertLogEvento(LogEvento logEventoNew)
        {
            bool result = false;
            try
            {
                Guid newId = Guid.NewGuid();
                logEventoNew.ID = newId.ToString();
                _dbcontext.LogEventos.Add(logEventoNew);
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return result;
        }
    
        public bool UpdateLogEvento(LogEvento logEventoUpd)
        {
            bool result = false;

            try
            {
                LogEvento logEventoUpdate = GetLogEvento(logEventoUpd.ID);
                if (logEventoUpdate != null)
                {
                    logEventoUpdate.Fecha = logEventoUpd.Fecha;
                    logEventoUpdate.UserId = logEventoUpd.UserId;
                    logEventoUpdate.TipoEvento = logEventoUpd.TipoEvento;
                    logEventoUpdate.Evento = logEventoUpd.Evento;
                    _dbcontext.Entry(logEventoUpdate).State = System.Data.Entity.EntityState.Modified;
                    _dbcontext.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }


            return result;
        }
    
    }
}
