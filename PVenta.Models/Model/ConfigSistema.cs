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
    [Table("ConfigSistemas")]
    public class ConfigSistema
    {
        [Key]
        [Column("ID", TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha de Inicio es requerida")]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Nombre Negocio")]
        [Required(ErrorMessage = "Nombre Negocio es requerido")]
        [Column("NombreNeg", TypeName = "varchar")]
        [MaxLength(50)]
        public string NombreNeg { get; set; }

        [DisplayName("Nombre Comercial")]
        [Column("NombreComercial", TypeName = "varchar")]
        [MaxLength(80)]
        public string NombreComercial { get; set; }

        [MaxLength(30)]
        public string RNC { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(150)]
        public string Direccion { get; set; }

        [MaxLength(150)]
        public string RelacionID { get; set; }

        [ForeignKey("RelacionID")]
        public InfoDigital InfoDigital { get; set; }

        [DisplayName("Calcula ITBIS")]
        public bool CalcITBIS { get; set; }

        [DisplayName("Porcentaje ITBIS")]
        public decimal PorcITBIS { get; set; }

        [DisplayName("Comprobante Fiscal")]
        [MaxLength(50)]
        public string ComprobanteFiscal { get; set; }

        [DisplayName("Numero Automatico Comprobante Fiscal")]
        public int NumComprobanteFiscal { get; set; }

        [DisplayName("Mensaje Orden")]
        [MaxLength(150)]
        public string MensajeOrden { get; set; }

        [DisplayName("Mensaje Factura")]
        [MaxLength(150)]
        public string MensajeFactura { get; set; }

        [DisplayName("Imprimir Comanda al Grabar")]
        public bool ImprimeComandaAuto { get; set; }

        [DisplayName("Imprimir Orden al Grabar")]
        public bool ImprimeOrdenAuto { get; set; }

        [DisplayName("Imprimir Factura al Grabar")]
        public bool ImprimeFacturaAuto { get; set; }

        [DisplayName("Codigo Seguridad")]
        public string CodigoSegInactivar { get; set; }
        public bool Inactivo { get; set; }
    }
}
