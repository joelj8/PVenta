using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
using PVenta.Utility;
using PVenta.WindForm.ApiCall;
using PVenta.WindForm.Define;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVenta.WindForm.AdmForms
{
    public partial class frmLogin : FormGRLA
    {
        static HttpClient client = new HttpClient();
        public viewLogin userSignIn = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnSignin_Click(object sender, EventArgs e)
        {

            userSignIn = valSign();

            if (userSignIn != null)
            {
                exit();
            }
            else
            {
                var result = MessageBox.Show("Usuario y/o Password invalido", "Login...",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void exit()
        {
            this.Close();
        }

        private  viewLogin valSign()
        {
            CallApies<viewLogin,ApiSignIn> callApi = new CallApies<viewLogin, ApiSignIn>();
            
            viewLogin result = null;
            ApiSignIn userlg = new ApiSignIn();
            userlg.Usuario = txtUsuario.Text;
            userlg.Password = txtPassword.Text;

            callApi.urlApi =  CollectAPI.SignIn;
            callApi.objectRequest = userlg;
            callApi.CallPost();

            result = callApi.objectResponse;

            callApi.urlApi = CollectAPI.SignIn;
            /*
             //Ejemplo de como llamar las API's
            CallApies<ApiUsuario, ApiUsuario> callApiUser = new CallApies<ApiUsuario, ApiUsuario>();
            callApiUser.urlApi = "api/Usuario/GetUsuario/";
            callApiUser.CallGet("4a123d40-fdc6-4723-b341-bb2cec1ef255");
            callApiUser.urlApi = "api/Usuario/GetUsuarios/";
            callApiUser.CallGetList();
            */
            return result;

        }
    
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            autoSignIn(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            autoSignIn(sender, e);
        }

        private void autoSignIn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r') && txtUsuario.Text != string.Empty &&
                txtPassword.Text != string.Empty)
            {
                this.btnSignin.PerformClick();
                //btnSignin_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
