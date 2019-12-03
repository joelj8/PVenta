﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewOrderHeader
    {
        public string ID { get; set; }
        public int NumOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string UserId { get; set; }
        public string MesaId { get; set; }
        public viewMesa Mesa { get; set; }
        public string ClientePrincipal { get; set; }
        public bool Itbis { get; set; }
        public decimal ItbisPorc { get; set; }
        public decimal DescMonto { get; set; }
        public decimal DescPorc { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Impreso { get; set; }
        public bool Inactivo { get; set; }
        public bool Servicio { get; set; }
        public decimal ServicioPorc { get; set; }

        //[JsonIgnore]
        public ICollection<viewOrderDetail> OrderDetails { get; set; }
    }
}
