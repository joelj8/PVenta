using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Models.ApiModels
{
    public class ApiLogEvento
    {

        public string ID { get; set; }

        public DateTime Fecha { get; set; }

        public string UserId { get; set; }
        public ApiUsuario Usuario { get; set; }

        public string TipoEvento { get; set; }

        public string ErrorListId { get; set; }

        public virtual ApiErrorList ErrorList { get; set; }

        public string msgError { get; set; }
    }
}
