﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiConfigSistema
    {
        public string ID { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NombreNeg { get; set; }
        public string NombreComercial { get; set; }
        public string RNC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string RelacionID { get; set; }
        public ICollection<ApiInfoDigital> InfoDigitals { get; set; }
        public bool CalcITBIS { get; set; }
        public decimal PorcITBIS { get; set; }
        public bool CalcServicio { get; set; }
        public decimal PorcServicio { get; set; }
        public string ComprobanteFiscal { get; set; }
        public int NumComprobanteFiscal { get; set; }
        public string MensajeOrden { get; set; }
        public int DiasOrden { get; set; }
        public string MensajeFactura { get; set; }
        public int DiasFactura { get; set; }
        public bool ImprimeComandaAuto { get; set; }
        public bool ImprimeOrdenAuto { get; set; }
        public bool ImprimeFacturaAuto { get; set; }
        public string CodigoSegInactivar { get; set; }
        public bool Inactivo { get; set; }
    }
}
