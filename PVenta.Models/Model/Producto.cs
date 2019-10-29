using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.Model
{
    public class Producto
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Nombre", TypeName = "varchar")]
        [MaxLength(80)]
        [Required(ErrorMessage = "Nombre del Producto es requerido")]
        [DisplayName("Nombre Producto")]
        public string Nombre { get; set; }

        [Column("NombreCorto", TypeName = "varchar")]
        [MaxLength(50)]
        [DisplayName("Nombre Corte Producto")]
        public string NombreCorto { get; set; }

        [Column("Precio")]
        [DisplayName("Precio Producto")]
        public string Precio { get; set; }

        [Column("CategoriaId", TypeName = "varchar")]
        [Required(ErrorMessage = "Categoria del Producto es requerida")]
        [DisplayName("Categoria Producto")]
        public string CategoriaId { get; set; }

        [NotMapped]
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        [DisplayName("Imprimir Comanda")]
        public bool ImpComanda { get; set; }

        [DisplayName("Adicional/Producto")]
        public bool esAdicional { get; set; }

        public bool Inactivo { get; set; }


    }
}
