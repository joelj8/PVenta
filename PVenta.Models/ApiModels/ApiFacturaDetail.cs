using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiFacturaDetail
    {
        public string ID { get; set; }
        public string FacturaHID { get; set; }
        public ApiFacturaHeader FacturaHeader { get; set; }
        public string OrderDID { get; set; }
        public string ProductoID { get; set; }
        public virtual ApiProducto producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public bool ImpComanda { get; set; }
        public string ClientePedido { get; set; }
        public bool Impreso { get; set; }
        public bool Inactivo { get; set; }
        public decimal Orden { get; set; }
    }
}
