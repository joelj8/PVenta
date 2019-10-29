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
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [DisplayName("ID Usuario")]
        [Column("UserId", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "User ID es requerido")]
        public string UserId { get; set; }

        [Column("Nombre", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Nombre de Usuario es requerido")]
        public string Nombre { get; set; }

        [DisplayName("Password")]
        [Column("pwduser", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Password es requerido")]
        public string Pwduser { get; set; }

        [Column("Email", TypeName ="varchar")]
        [MaxLength(80)]
        public string Email { get; set; }

        [DisplayName("ID Rol")]
        [Column("RolId", TypeName = "varchar")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Rol ID es requerido")]
        public string RolId { get; set; }

        [NotMapped]
        public virtual Rol Rol { get; set; }

        [DisplayName("Usuario es Cajero")]
        public bool esCajero { get; set; }

        public bool Inactivo { get; set; }

    }
}
