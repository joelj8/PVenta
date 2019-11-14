using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewLogin
    {
        public string ID { get; set; }
        public string UserID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public bool esCajero { get; set; }
        public string RolID { get; set; }
    }
}
