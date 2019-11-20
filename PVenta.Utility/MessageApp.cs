using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Utility
{
    public class MessageApp
    {
        public MessageApp()
        {

        }
        public MessageApp(ErrorList errorList)
        {
            if (errorList != null)
            {
                this.Codigo = errorList.Codigo;
                this.esError = errorList.esError;
                this.Evento = errorList.MsgError;
            }
        }

        public string Codigo { get; } = "N/D";
        public bool esError { get; } = false;
        public string Evento { get; } = "N/D";

    }
}
