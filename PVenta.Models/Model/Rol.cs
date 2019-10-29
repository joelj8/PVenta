using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.Model
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Nombre", TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public bool Modificable { get; set; }
        public bool Inactivo { get; set; }



    }
}
