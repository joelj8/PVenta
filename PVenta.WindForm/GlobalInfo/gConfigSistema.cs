using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
using PVenta.Utility;
using PVenta.WindForm.ApiCall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.WindForm.GlobalInfo
{
    public static class gConfigSistema
    {
        private static CallApies<viewConfigSistema, ApiConfigSistema> callApiMesa = new CallApies<viewConfigSistema, ApiConfigSistema>();
        public static viewConfigSistema configSistemaInfo {
            get
            {
                callApiMesa.urlApi = CollectAPI.GetConfigSistemas;
                callApiMesa.CallGetList();
                return callApiMesa.listaResponse.FirstOrDefault();

            }
         }



    }
}
