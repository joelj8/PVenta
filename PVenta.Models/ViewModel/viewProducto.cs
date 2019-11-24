using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewProducto
    {
        public string ID { get; set; }

        public string Nombre { get; set; }

        public string NombreCorto { get; set; }

        public string Referencia { get; set; }

        public string Precio { get; set; }

        public string CategoriaId { get; set; }

        public virtual viewCategoria Categoria { get; set; }

        public bool ImpComanda { get; set; }

        public bool esAdicional { get; set; }

        public bool Inactivo { get; set; }


    }
}
