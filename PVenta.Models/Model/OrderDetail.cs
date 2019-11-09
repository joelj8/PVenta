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
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("OrderHID", TypeName = "varchar")]
        [Required(ErrorMessage = "Orden Header es requerida")]
        [MaxLength(50)]
        [DisplayName("Header de Orden")]
        public string OrderHID { get; set; }

        [ForeignKey("OrderHID")]
        public OrderHeader OrderHeader { get; set; }

        [Column("ProductoID", TypeName = "varchar")]
        [Required(ErrorMessage = "Producto es requerido")]
        [MaxLength(50)]
        [DisplayName("Producto de Factura")]
        public string ProductoID { get; set; }

        [ForeignKey("ProductoID")]
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
    }
}
