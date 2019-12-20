using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewFormaPago
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string MonedaID { get; set; }
        public bool AceptaCambio { get; set; }
        public bool Inactivo { get; set; }
    }
}
