using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiUsuario
    {
        public string ID { get; set; }
        public string UserId { get; set; }
        public string Nombre { get; set; }
        public string Pwduser { get; set; }
        public string Email { get; set; }
        public string RolId { get; set; }
        public virtual ApiRol Rol { get; set; }
        public bool esCajero { get; set; }
        public bool Inactivo { get; set; }
    }
}
