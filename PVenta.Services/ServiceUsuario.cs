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
    public class ServiceUsuario
    {
        private readonly DBPVentaContext _dbcontext;

        public ServiceUsuario()
        {
            _dbcontext = new DBPVentaContext();
        }

        public List<Usuario> GetUsuarios()
        {
            var result = _dbcontext.Usuarios.Include("Rol").Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Usuario GetUsuario(string id)
        {
            var result = _dbcontext.Usuarios.Include("Rol").FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public MessageApp InsertUsuario(Usuario UsuarioNew)
        {
            MessageApp result = null;
            List<Usuario> listaUsuarioByUserId = findUserId(UsuarioNew);
            if (listaUsuarioByUserId != null && listaUsuarioByUserId.Count == 0)
            {
                try
                {
                    Guid newId = Guid.NewGuid();
                    UsuarioNew.ID = newId.ToString();
                    _dbcontext.Usuarios.Add(UsuarioNew);
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

        public MessageApp UpdateUsuario(Usuario UsuarioUpd)
        {
            MessageApp result = null;
            List<Usuario> listaUsuarioByUserId = findUserId(UsuarioUpd);
            if (listaUsuarioByUserId != null && listaUsuarioByUserId.Count == 0)
            {
                try
                {
                    Usuario UsuarioUpdate = GetUsuario(UsuarioUpd.ID);
                    if (UsuarioUpdate != null)
                    {
                        UsuarioUpdate.Nombre = UsuarioUpd.Nombre;
                        UsuarioUpdate.Pwduser = UsuarioUpd.Pwduser;
                        UsuarioUpdate.RolId = UsuarioUpd.RolId;
                        UsuarioUpdate.UserId = UsuarioUpd.UserId;
                        UsuarioUpdate.Email = UsuarioUpd.Email;
                        UsuarioUpdate.esCajero = UsuarioUpd.esCajero;

                        _dbcontext.Entry(UsuarioUpdate).State = System.Data.Entity.EntityState.Modified;
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
            }
            else
            {
                result = new MessageApp(ServiceEventApp.GetEventByCode("EL00002"));
            }
                


            return result;
        }

        public MessageApp DeleteUsuario(string id)
        {
            MessageApp result = null;

            try
            {
                Usuario UsuarioDelete = GetUsuario(id);
                if (UsuarioDelete != null)
                {
                    UsuarioDelete.Inactivo = true;
                    _dbcontext.Entry(UsuarioDelete).State = System.Data.Entity.EntityState.Modified;
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
   
        public List<Usuario> findUserId(Usuario findusuario)
        {
            List<Usuario> usuarioLista = null;
            try
            {
                usuarioLista = _dbcontext.Usuarios.Where(x => !x.Inactivo && x.ID != findusuario.ID &&
                                                                x.UserId.Equals(findusuario.UserId)).ToList();
            }
            catch (Exception)
            {
                // Registrar en el log de errores
            }


            return usuarioLista;
        }
    }
}
