﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiErrorList
    {
        public string ID { get; set; }

        public string Codigo { get; set; }

        public string MsgError { get; set; }
        public bool Inactivo { get; set; }
    }
}