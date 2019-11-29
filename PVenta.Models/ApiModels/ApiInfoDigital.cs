using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiInfoDigital
    {
        public string ID { get; set; }
        public string RelacionID { get; set; }
        public string TypeInfoID { get; set; }
        public ApiTypeInformacion TypeInfo { get; set; }
        public string Descripcion { get; set; }
        public bool Inactivo { get; set; }
    }
}
