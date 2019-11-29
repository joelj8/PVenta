using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ViewModel
{
    public class viewInfoDigital
    {
        public string ID { get; set; }
        public string RelacionID { get; set; }
        public string TypeInfoID { get; set; }
        public viewTypeInfo TypeInfo { get; set; }
        public string Descripcion { get; set; }
        public bool Inactivo { get; set; }
    }
}
