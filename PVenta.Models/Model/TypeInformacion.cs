using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.Model
{
    [Table("TypeInformaciones")]
    public class TypeInformacion
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("Descripcion", TypeName = "varchar")]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public bool Inactivo { get; set; }
    }
}
