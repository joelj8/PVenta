using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
using PVenta.Utility;
using PVenta.WindForm.ApiCall;
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
    public partial class frmRoles : Form
    {
        public string RolID { get; set; }
        public Modo modo { get; set; }
        private viewMessageApp result = null;
        private ApiRol rol = new ApiRol();

        private CallApies<viewRol, ApiRol> callApiRol = new CallApies<viewRol, ApiRol>();
        private CallApies<viewMessageApp, ApiRol> MngApiRol = new CallApies<viewMessageApp, ApiRol>();

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {

        }

        public void setData()
        {
            if (RolID != string.Empty)
            {
                callApiRol.urlApi = "api/Rol/GetRol/";
                callApiRol.CallGet(RolID);
                txtNombre.Text = callApiRol.objectResponse.Nombre;
                chkModificable.Checked = callApiRol.objectResponse.Modificable;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (modo == Modo.Agregar)
            {
                agregarRol();
            }
            else if (modo == Modo.Editar)
            {
                editarRol();
            }

            if (result != null)
            {
                MessageBoxIcon msgIcon = result.esError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
                MessageBox.Show(result.Evento, this.Text.ToString(),MessageBoxButtons.OK, msgIcon);
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

        private void editarRol()
        {
            rol.ID = callApiRol.objectResponse.ID;
            rol.Nombre = txtNombre.Text.ToString();
            rol.Modificable = chkModificable.Checked;
            MngApiRol.urlApi = "api/Rol/UpdateRol";
            MngApiRol.objectRequest = rol;
            MngApiRol.CallPost();
            result = MngApiRol.objectResponse;
        }

        private void agregarRol()
        {
            rol.Nombre = txtNombre.Text.ToString();
            rol.Modificable = chkModificable.Checked;
            MngApiRol.urlApi = "api/Rol/InsertRol";
            MngApiRol.objectRequest = rol;
            MngApiRol.CallPost();
            result = MngApiRol.objectResponse;
        }
    }
}
