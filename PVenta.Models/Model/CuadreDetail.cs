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
    public class CuadreDetail
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [Column("CuadreHID", TypeName = "varchar")]
        [Required(ErrorMessage = "Cuadre Header es requerida")]
        [MaxLength(50)]
        [DisplayName("Header del Cuadre")]
        
        public string CuadreHID { get; set; }

        [NotMapped]
        [ForeignKey("CuadreHID")]
        public CuadreHeader CuadreH { get; set; }

        [Column("MonedaId", TypeName = "varchar")]
        [Required(ErrorMessage = "Moneda es requerida")]
        [MaxLength(50)]
        [DisplayName("Moneda")]
        public string MonedaId { get; set; }

        public Moneda Moneda { get; set; }

        [Column("Cantidad" )]
        [Required(ErrorMessage = "Cantidad es requerida")]
        [DisplayName("Cantidad de Moneda")]
        public decimal Cantidad { get; set; }

        [Column("Valor")]
        [Required(ErrorMessage = "Valor Moneda es requerido")]
        [DisplayName("Valor de la Moneda")]
        public decimal Valor { get; set; }

    }
}
