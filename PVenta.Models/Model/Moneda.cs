using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.Model
{
    [Table("Monedas")]
    public class Moneda
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Descripcion", TypeName = "varchar")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Descripción es requerida")]
        public string Descripcion { get; set; }

        [Column("Valor")]
        [Range(0.01, 999999999, ErrorMessage = "Valor debe ser mayor a 0.00")]
        public decimal Valor { get; set; }

        public bool Inactivo { get; set; }
    }
}
