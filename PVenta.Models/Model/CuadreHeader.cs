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
    public class CuadreHeader
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required(ErrorMessage = "Usuario Cuadre es requerido")]
        [Column("UserId", TypeName = "varchar")]
        [MaxLength(50)]
        public string UserId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha de Cuadre es requerida")]
        public DateTime Fecha { get; set; }

        [Column("MontoInicial", TypeName = "decimal(16,2)")]
        [DisplayName("Monto Inicial Cuadre")]
        public decimal MontoInicial { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaReg { get; set; }

        [Column("AdmUserId", TypeName = "varchar")]
        [MaxLength(50)]
        public string AdmUserId { get; set; }

        public bool Cerrado { get; set; }

        public string Comentario { get; set; }
        public bool Inactivo { get; set; }



    }
}
