﻿using PVenta.DAL;
using PVenta.Models.Model;
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
            var result = _dbcontext.Usuarios.Where(x => !x.Inactivo).ToList();
            return result;
        }

        public Usuario GetUsuario(string id)
        {
            var result = _dbcontext.Usuarios.FirstOrDefault(x => x.ID == id && !x.Inactivo);
            return result;
        }

        public bool InsertUsuario(Usuario UsuarioNew)
        {
            bool result = false;
            try
            {
                Guid newId = Guid.NewGuid();
                UsuarioNew.ID = newId.ToString();
                _dbcontext.Usuarios.Add(UsuarioNew);
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                // Registrar en el log de Errores
            }
            return result;
        }

        public bool UpdateUsuario(Usuario UsuarioUpd)
        {
            bool result = false;

            try
            {
                Usuario UsuarioUpdate = GetUsuario(UsuarioUpd.ID);
                UsuarioUpdate.Nombre = UsuarioUpd.Nombre;
                UsuarioUpdate.Pwduser = UsuarioUpd.Pwduser;
                UsuarioUpdate.RolId = UsuarioUpd.RolId;
                UsuarioUpdate.UserId = UsuarioUpd.UserId;
                UsuarioUpdate.Email = UsuarioUpd.Email;
                UsuarioUpdate.esCajero = UsuarioUpd.esCajero;
                
                _dbcontext.Entry(UsuarioUpdate).State = System.Data.Entity.EntityState.Modified;
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }


            return result;
        }

        public bool DeleteUsuario(string id)
        {
            bool result = false;

            try
            {
                Usuario UsuarioUpdate = GetUsuario(id);
                UsuarioUpdate.Inactivo = true;
                _dbcontext.Entry(UsuarioUpdate).State = System.Data.Entity.EntityState.Modified;
                _dbcontext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {

                // Registrar en el log de errores
            }


            return result;
        }
    }
}
