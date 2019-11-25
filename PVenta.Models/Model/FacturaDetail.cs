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
    [Table("FacturaDetails")]
    public class FacturaDetail
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("FacturaHID", TypeName = "varchar")]
        [Required(ErrorMessage = "Factura Header es requerida")]
        [MaxLength(50)]
        [DisplayName("ID Header de Factura")]
        public string FacturaHID { get; set; }

        [ForeignKey("FacturaHID")]
        public FacturaHeader FacturaHeader { get; set; }

        [Column("OrderDID", TypeName = "varchar")]
        [MaxLength(50)]
        [DisplayName("ID Detail de Order")]
        public string OrderDID { get; set; }

        [Column("ProductoID", TypeName = "varchar")]
        [Required(ErrorMessage = "Producto es requerido")]
        [MaxLength(50)]
        [DisplayName("Producto de Factura")]
        public string ProductoID { get; set; }

        public virtual Producto producto { get; set; }

        [Column("Cantidad")]
        [Required(ErrorMessage = "Cantidad es requerida")]
        [DisplayName("Cantidad del Producto")]
        public decimal Cantidad { get; set; }

        [Column("Precio")]
        [Required(ErrorMessage = "Precio es requerido")]
        [DisplayName("Precio del Producto")]
        public decimal Precio { get; set; }

        [DisplayName("Imprimir Comanda")]
        public bool ImpComanda { get; set; }

        [Column("ClientePedido", TypeName = "varchar")]
        [DisplayName("Cliente del Pedido")]
        [MaxLength(50)]
        public string ClientePedido { get; set; }

        public bool Impreso { get; set; }

        public bool Inactivo { get; set; }

        public decimal Orden { get; set; }

    }
}
