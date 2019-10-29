using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiRol
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public bool Modificable { get; set; }
        public bool Inactivo { get; set; }
    }
}
