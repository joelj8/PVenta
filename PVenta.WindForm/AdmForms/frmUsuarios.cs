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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVenta.WindForm.AdmForms
{
    public partial class frmUsuarios : FormGRLA
    {
        public Modo modo { get; set; }
        public string UsuarioID { get; set; }

        private viewMessageApp result = null;
        private ApiUsuario usuario = new ApiUsuario();

        private CallApies<viewUsuario, ApiUsuario> callApiUsuario = new CallApies<viewUsuario, ApiUsuario>();
        private CallApies<viewRol, ApiRol> callApiRol = new CallApies<viewRol, ApiRol>();
        private CallApies<viewMessageApp, ApiUsuario> MngApiUsuario = new CallApies<viewMessageApp, ApiUsuario>();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        public void setData()
        {
            setDataCombo();

            if (UsuarioID != string.Empty)
            {
                callApiUsuario.urlApi = CollectAPI.GetUsuario;
                callApiUsuario.CallGet(UsuarioID);
                if (callApiUsuario.objectResponse != null)
                {
                    txtUserID.Text = callApiUsuario.objectResponse.UserId;
                    txtUserID.ReadOnly = true;
                    txtNombre.Text = callApiUsuario.objectResponse.Nombre;
                    txtEmail.Text = callApiUsuario.objectResponse.Email;
                    cboRol.SelectedValue = callApiUsuario.objectResponse.RolId;
                    chkEsCajero.Checked = callApiUsuario.objectResponse.esCajero;
                    txtPassword.Text = callApiUsuario.objectResponse.Pwduser;
                    txtConfirmar.Text = callApiUsuario.objectResponse.Pwduser;
                }
                
                
            }
        }

        public void setDataCombo()
        {
            //cboRol.DataSource = string.Empty;

            callApiRol.urlApi = CollectAPI.GetRoles;
            callApiRol.CallGetList();
            if (callApiRol.listaResponse != null)
            {
                BindingSource bdS = new BindingSource();
                bdS.DataSource = callApiRol.listaResponse;
                cboRol.DataSource = bdS.DataSource;

                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "ID";
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool validado = validarData();
            if (validado)
            {
                switch (this.modo)
                {
                    case Modo.Agregar:
                        saveData(CollectAPI.InsertUsuario);
                        break;
                    case Modo.Editar:
                        saveData(CollectAPI.UpdateUsuario);
                        break;
                }

                msgResult();

            }

        }

        private void msgResult()
        {
            if (result != null)
            {
                MessageBoxIcon msgIcon = result.esError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
                MessageBox.Show(result.Evento, this.Text.ToString(), MessageBoxButtons.OK, msgIcon);
                if (!result.esError)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error no controlado...", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prepareData()
        {
            if (modo == Modo.Agregar)
            {
                usuario.UserId = txtUserID.Text;
            }

            if (modo == Modo.Editar)
            {
                usuario.ID = UsuarioID;
            }

            usuario.UserId = txtUserID.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Email = txtEmail.Text;
            usuario.RolId = cboRol.SelectedValue.ToString();
            usuario.Pwduser = txtPassword.Text;
            usuario.esCajero = chkEsCajero.Checked;
            
        }

        private void saveData(string urlApi)
        {
            prepareData();

            MngApiUsuario.urlApi = urlApi;
            MngApiUsuario.objectRequest = usuario;
            MngApiUsuario.CallPost();
            result = MngApiUsuario.objectResponse;
        }

        private bool validarData()
        {
            bool validaResult = true;

            // Validando el User ID
            if (txtUserID.Text == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar el User ID...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando el Nombre
            if (txtNombre.Text == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar el Nombre del Usuario...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando el Rol
            if (cboRol.SelectedValue.ToString() == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar el Rol del Usuario...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando la contraseña 
            if ((txtPassword.Text != string.Empty || 
                txtConfirmar.Text != string.Empty) &&
                txtConfirmar.Text != txtPassword.Text && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, La contraseña no coincide...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando la contraseña - No debe estar en blanco
            if (txtPassword.Text == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar la contraseña...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validando el UserId
            string usuariorId = txtUserID.Text;
            callApiUsuario.urlApi = CollectAPI.GetUsuarios;
            callApiUsuario.CallGetList();
            int cantUserExist = (from dt in callApiUsuario.listaResponse
                            where dt.ID != UsuarioID && 
                                  dt.UserId.ToLower() == usuariorId.ToLower()
                            select dt).Count();
            if (cantUserExist > 0 && validaResult)
            {
                validaResult = false;
                MessageBox.Show(string.Format("Error, El Usuario ID '{0}' fue registrado previamente...",usuariorId), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return validaResult;
            
        }
    }
}
