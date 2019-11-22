using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewMesa
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public bool Inactivo { get; set; }
    }
}
