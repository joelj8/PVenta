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

namespace PVenta.WindForm.MantForms
{
    public partial class frmMesas : FormGRLA
    {
        public Modo modo { get; set; }
        public string MesaID { get; set; }
        private viewMessageApp result = null;
        private ApiMesa mesa = new ApiMesa();

        private CallApies<viewMesa, ApiMesa> callApiMesa = new CallApies<viewMesa, ApiMesa>();
        private CallApies<viewMessageApp, ApiMesa> MngApiMesa = new CallApies<viewMessageApp, ApiMesa>();

        public frmMesas()
        {
            InitializeComponent();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {

        }

        public void setData()
        {
            if (MesaID != string.Empty)
            {
                callApiMesa.urlApi = CollectAPI.GetMesa;
                callApiMesa.CallGet(MesaID);
                if (callApiMesa.objectResponse != null)
                {
                    txtDescripcion.Text = callApiMesa.objectResponse.Descripcion;
                    numOrden.Value = callApiMesa.objectResponse.Orden;
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertMesa);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateMesa);
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

        private void saveData(string urlApi)
        {
            prepareData();
            MngApiMesa.urlApi = urlApi;
            MngApiMesa.objectRequest = mesa;
            MngApiMesa.CallPost();
            result = MngApiMesa.objectResponse;
        }

        private void prepareData()
        {
            if (modo == Modo.Editar)
            {
                mesa.ID = MesaID;
            }

            mesa.Descripcion = txtDescripcion.Text;
            mesa.Orden = int.Parse(numOrden.Value.ToString());
        }
    }
}
