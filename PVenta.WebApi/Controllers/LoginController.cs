using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
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

        public ApiLogin SingIn(ApiSignIn userlogin )
        {
            ApiLogin result = serviceLogin.LoginUser(userlogin.Usuario, userlogin.Password);
            return result;
        }
    }
}
