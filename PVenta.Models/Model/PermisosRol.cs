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
    [Table("PermisosRol")]
    public class PermisosRol
    {

        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [DisplayName("ID Rol Usuario")]
        [Column("RolId", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Rol del Usuario es requerido")]
        public string RolId { get; set; }

        [DisplayName("ID Opción Sistema")]
        [Column("OpcionId", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Opción del Sistema es requerida")]
        public string OpcionId { get; set; }

        public bool Inactivo { get; set; }
    }
}
