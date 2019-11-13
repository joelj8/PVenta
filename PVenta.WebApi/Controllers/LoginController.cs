using PVenta.Models.ApiModels;
using PVenta.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PVenta.WebApi.Controllers
{
    public class LoginController : ApiController
    {
        private readonly ServiceLogin serviceLogin;

        public LoginController()
        {
            serviceLogin = new ServiceLogin();
        }

        public ApiLogin SingIn(string usuario, string password)
        {
            ApiLogin result = serviceLogin.LoginUser(usuario, password);
            return result;
        }
    }
}
