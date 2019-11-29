using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewConfigSistema
    {
        public string ID { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NombreNeg { get; set; }
        public string NombreComercial { get; set; }
        public string RNC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string RelacionID { get; set; }
        public viewInfoDigital InfoDigital { get; set; }
        public bool CalcITBIS { get; set; }
        public decimal PorcITBIS { get; set; }
        public string ComprobanteFiscal { get; set; }
        public int NumComprobanteFiscal { get; set; }
        public string MensajeOrden { get; set; }
        public string MensajeFactura { get; set; }
        public bool ImprimeComandaAuto { get; set; }
        public bool ImprimeOrdenAuto { get; set; }
        public bool ImprimeFacturaAuto { get; set; }
        public string CodigoSegInactivar { get; set; }
        public bool Inactivo { get; set; }
    }
}
