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
    public partial class frmRoles : FormGRLA
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
                callApiRol.urlApi = CollectAPI.GetRol;
                callApiRol.CallGet(RolID);
                if (callApiRol.objectResponse != null)
                {
                    txtNombre.Text = callApiRol.objectResponse.Nombre;
                    chkModificable.Checked = callApiRol.objectResponse.Modificable;
                }
                
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertRol);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateRol);
                    break;
            }

            msgResult();
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
            if (modo == Modo.Editar)
            {
                rol.ID = RolID;
            }
                
            rol.Nombre = txtNombre.Text;
            rol.Modificable = chkModificable.Checked;
        }

        private void saveData(string urlApi)
        {
            prepareData();
            MngApiRol.urlApi = urlApi;
            MngApiRol.objectRequest = rol;
            MngApiRol.CallPost();
            result = MngApiRol.objectResponse;
        }
    }
}
