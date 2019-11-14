using PVenta.DAL;
using PVenta.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public class ServiceLogin
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceLogin()
        {
            _dbcontext = new DBPVentaContext();
        }

        public ApiLogin LoginUser(string userid, string pssword)
        {
            ApiLogin result = null;
            try
            {
               var userReg = _dbcontext.Usuarios.Where(x => !x.Inactivo && x.UserId.Equals(userid) &&
                                          x.Pwduser.Equals(pssword,StringComparison.Ordinal)).FirstOrDefault();
                if(userReg != null)
                {
                    result = new ApiLogin();
                    result.ID = userReg.ID;
                    result.UserID = userReg.UserId;
                    result.Nombre = userReg.Nombre;
                    result.Email = userReg.Email;
                    result.esCajero = userReg.esCajero;
                    result.RolID = userReg.RolId;
                }
            }
            catch (Exception)
            {
                // Registrar en el log de Errores
            }
            return result;
        }
    }
}
