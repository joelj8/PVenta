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
    [Table("FormaPagos")]
    public class FormaPago
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Descripcion", TypeName = "varchar")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Descripción es requerida")]
        public string Descripcion { get; set; }

        [DisplayName("Nombre Moneda")]
        public string MonedaID { get; set; }

        public bool Inactivo { get; set; }

    }
}
