using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiPermisosRol
    {
        public string ID { get; set; }

        public string RolId { get; set; }

        public virtual ApiRol Rol { get; set; }

        public string OpcionId { get; set; }

        public virtual ApiOpcionesSist OpcionesSist { get; set; }

        public bool Inactivo { get; set; }
    }
}
