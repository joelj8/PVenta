using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewFacturaDetail
    {
        public string ID { get; set; }
        public string FacturaHID { get; set; }
        public viewFacturaHeader FacturaHeader { get; set; }
        public string OrderDID { get; set; }
        public string ProductoID { get; set; }
        public virtual viewProducto producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public bool ImpComanda { get; set; }
        public string ClientePedido { get; set; }
        public bool Impreso { get; set; }
        public bool Inactivo { get; set; }
        public decimal Orden { get; set; }
    }
}
