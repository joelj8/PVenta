using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiProducto
    {
        private string _nombre;
        public string ID { get; set; }
        public string Nombre {
            get
            {
                string nombreRetornar = esAdicional ? "      " + _nombre.Trim() : _nombre.Trim();
                return nombreRetornar;
            }
            set { _nombre = value.Trim(); }
        }
        public string NombreCorto { get; set; }
        public string Referencia { get; set; }
        public decimal Precio { get; set; }
        public string CategoriaId { get; set; }
        public virtual ApiCategoria Categoria { get; set; }
        public bool ImpComanda { get; set; }
        public bool esAdicional { get; set; }
        public bool permiteAdicional { get; set; }
        public bool Inactivo { get; set; }
    }
}
