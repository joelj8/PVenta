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
 
    [Table("LogEventos")]
    public class LogEvento
    {
        [Key]
        [Column("ID", TypeName ="varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [DisplayName("Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha es Requerida")]
        public DateTime Fecha { get; set; }

        [DisplayName("Usuario")]
        [Column("UserId", TypeName = "varchar")]
        [MaxLength(50)]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Usuario Usuario { get; set; }

        [DisplayName("Tipo Evento")]
        [Column("TipoEvento", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Tipo Evento es Requerido")]
        public string TipoEvento { get; set; }

        [DisplayName("Evento")]
        [Column("Evento", TypeName = "varchar")]
        [MaxLength(3000)]
        public string Evento { get; set; }

    }
}
