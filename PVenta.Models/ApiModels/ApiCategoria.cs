using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiCategoria
    {
        public string ID { get; set; }

        public string Descripcion { get; set; }

        public bool ImpComanda { get; set; }

        public bool Inactivo { get; set; }
    }
}
