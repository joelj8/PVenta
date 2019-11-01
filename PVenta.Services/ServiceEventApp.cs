using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Services
{
    public static class ServiceEventApp
    {
        private static readonly ServiceErrorList _serviceErrorList = new ServiceErrorList();

        public static ErrorList GetEventByCode(string iderror)
        {
            return _serviceErrorList.GetErrorListByCodigo(iderror);
        } 
    }
}
