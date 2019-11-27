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
    [Table("OrderHeaders")]
    public class OrderHeader
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumOrden { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha de Factura es requerida")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Usuario Factura es requerida")]
        [Column("UserId", TypeName = "varchar")]
        [MaxLength(50)]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Mesa Factura es requerida")]
        [Column("MesaId", TypeName = "varchar")]
        [MaxLength(50)]
        public string MesaId { get; set; }

        [ForeignKey("MesaId")]
        public Mesa Mesa { get; set; }

        [Column("ClientePrinc", TypeName = "varchar")]
        [MaxLength(50)]
        [DisplayName("Cliente Principal")]
        public string ClientePrincipal { get; set; }

        public bool Itbis { get; set; }

        [Column("ItbisPorc")]
        public decimal ItbisPorc { get; set; }

        [Column("DescMonto")]
        public decimal DescMonto { get; set; }

        [Column("DescPorc")]
        public decimal DescPorc { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column("FechaReg", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }

        public bool Impreso { get; set; }

        public bool Inactivo { get; set; }


        public ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
