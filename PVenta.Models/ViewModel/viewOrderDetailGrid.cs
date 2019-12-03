using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewOrderDetailGrid : ICloneable
    {
        public string ID { get; set; }
        public string OrderHID { get; set; }
        public string ProductoID { get; set; }
        public string producto { get; set; }
        public string Referencia { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get { return this.Precio * this.Cantidad; } }
        public bool ImpComanda { get; set; }
        public string ClientePedido { get; set; }
        public bool Impreso { get; set; }
        public bool Inactivo { get; set; }
        public decimal Orden { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
