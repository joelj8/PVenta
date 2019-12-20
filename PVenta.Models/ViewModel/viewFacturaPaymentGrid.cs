using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewFacturaPaymentGrid
    {
        public string FormaPagoId { get; set; }
        public string FormaPago { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoDevolver { get; set; }
        public string InfoPago { get; set; }

    }
}
