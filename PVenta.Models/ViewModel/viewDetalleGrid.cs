using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewDetalleGrid
    {
        public string ProductoID { get; set; }
        public string Producto { get; set; }
        public string Referencia { get; set; }
        public decimal Orden { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string ID { get; set; }
        public string IDRelaciona { get; set; }

    }
}
