using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.WindForm.ApiCall
{
    public class Template
    {

    }
    public class CallApies<TRespond, TRequest> where TRespond: class 
    {
        private readonly HttpClient client = new HttpClient();

        public string urlApi { get; set; }
        public TRequest objectRequest { get; set; }

        public TRespond objectResponse { get; set; }

        public IEnumerable<TRespond> listaResponse { get; set; }

        public void CallPost() 
        {
            setClient();

            TRespond result = null  ;
            
            try
            {
                //"api/Login/singin"
                // HTTP POST
                setClient();
                HttpResponseMessage response =  client.PostAsJsonAsync(urlApi, objectRequest).Result;
                // response.EnsureSuccessStatusCode();
                
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    result = response.Content.ReadAsAsync<TRespond>().Result;
                } 
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    result = response.Content.ReadAsAsync<TRespond>().Result;
                }
                
            }
            catch(Exception ex)
            {
                // Error 
                
            }
            objectResponse = result;
        }

        public void CallGet(string id)
        {
            setClient();

            TRespond result = null;

            try
            {
                // HTTP GET
                setClient();
                HttpResponseMessage response = client.GetAsync(urlApi+id).Result;

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    result = response.Content.ReadAsAsync<TRespond>().Result;
                }
            }
            catch (Exception ex)
            {
                // Error 
            }
            objectResponse = result;
        }
        public void CallGetList()
        {
            setClient();

            IEnumerable<TRespond>result = null;

            try
            {
                // HTTP GET
                setClient();
                HttpResponseMessage response = client.GetAsync(urlApi).Result;
                    
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    result = response.Content.ReadAsAsync<IEnumerable<TRespond>>().Result;
                }
            }
            catch (Exception ex)
            {
                // Error 
            }
            listaResponse = result.ToList();
        }

        private void setClient()
        {
            if (client.BaseAddress == null)
            {
                string setUrlApi = Properties.Settings.Default.ApiURLPVenta;
                client.BaseAddress = new Uri(setUrlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

        }
    }
}
