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
    [Table("ErrorList")]
    public class ErrorList
    {

        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [DisplayName("Codigo")]
        [Column("Codigo", TypeName = "varchar")]
        [Required(ErrorMessage = "Código es Requerido")]
        public string Codigo { get; set; }

        [DisplayName("MsgError")]
        [DataType(DataType.Text)]
        [Column("MsgError", TypeName = "varchar")]
        [MaxLength(3000)]
        [Required(ErrorMessage = "Mensaje de Error es Requerido")]
        public string MsgError { get; set; }

        [DisplayName("Es un Error")]
        public bool esError { get; set; }
        
        public bool Inactivo { get; set; }
    }
}
