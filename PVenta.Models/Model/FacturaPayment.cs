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
    [Table("FacturaPayments")]
    public class FacturaPayment
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("FacturaHID", TypeName = "varchar")]
        [Required(ErrorMessage = "Factura Header es requerida")]
        [MaxLength(50)]
        [DisplayName("Header de Factura")]
        public string FacturaHID { get; set; }

        [ForeignKey("FacturaHID")]
        public FacturaHeader FacturaHeader { get; set; }

        [Required(ErrorMessage = "Usuario Pago de Factura es requerido")]
        [Column("UserId", TypeName = "varchar")]
        [MaxLength(50)]
        public string UserId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha de Pago Factura es requerida")]
        public DateTime FechaPago { get; set; }

        [Column("MontoPago")]
        [DisplayName("Monto del Pago")]
        public decimal MontoPago { get; set; }

        [Column("MontoDevolver")]
        [DisplayName("Monto a Devolver")]
        public decimal MontoDevolver { get; set; }

        public string FormaPagoId { get; set; }

        [ForeignKey("FormaPagoId")]
        public FormaPago FormaPago { get; set; }

        public string InfoPago { get; set; }

        public bool Inactivo { get; set; }
    }
}
