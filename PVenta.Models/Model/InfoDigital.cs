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
    [Table("InfoDigitals")]
    public class InfoDigital
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("IDRelacion", TypeName = "varchar")]
        [MaxLength(50)]
        public string RelacionID { get; set; }
        
        [MaxLength(50)]
        public string TypeInfoID { get; set; }

        [ForeignKey("TypeInfoID")]
        public TypeInformacion TypeInfo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }

        public bool Inactivo { get; set; }
    }
}
