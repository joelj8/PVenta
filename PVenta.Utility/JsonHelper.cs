using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PVenta.Utility
{
    public class JsonHelper<T> where T : class
    {
        private readonly JsonSerializerSettings settings = new JsonSerializerSettings();
        public JsonHelper()
        {
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //return Json<List<ApiOrderHeader>>(order);
        }

        /*
        public System.Web.Mvc.JsonResult getJson(Type classtype, T obj)
        {
            return Json<classtype>(obj,this.settings);
        }
        */
    }
}
