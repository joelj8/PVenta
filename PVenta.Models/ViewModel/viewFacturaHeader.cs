using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewFacturaHeader
    {
        public string ID { get; set; }
        public int NumFactura { get; set; }
        public string OrderHID { get; set; }
        public DateTime Fecha { get; set; }
        public string UserId { get; set; }
        public string MesaId { get; set; }
        public string ClientePrincipal { get; set; }
        public bool Itbis { get; set; }
        public decimal ItbisPorc { get; set; }
        public decimal DescMonto { get; set; }
        public decimal DescPorc { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Impreso { get; set; }
        public bool Inactivo { get; set; }
        public ICollection<viewFacturaDetail> FacturaDetails { get; set; }
        public ICollection<viewFacturaPayment> FacturaPayments { get; set; }
    }
}
