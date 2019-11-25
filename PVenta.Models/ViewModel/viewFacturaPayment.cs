using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewFacturaPayment
    {
        public string ID { get; set; }
        public string FacturaHID { get; set; }
        public viewFacturaHeader FacturaHeader { get; set; }
        public string UserId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }
        public bool Inactivo { get; set; }
    }
}
