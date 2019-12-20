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
    public partial class frmFormaPagos : FormGRLA
    {
        public Modo modo { get; set; }
        public string FormaPagoID { get; set; }
        private viewMessageApp result = null;
        private ApiFormaPago formaPago = new ApiFormaPago();

        private CallApies<viewFormaPagos, ApiFormaPago> callApiFormaPago = new CallApies<viewFormaPagos, ApiFormaPago>();
        private CallApies<viewMessageApp, ApiFormaPago> MngApiFormaPago = new CallApies<viewMessageApp, ApiFormaPago>();

        public frmFormaPagos()
        {
            InitializeComponent();
        }

        private void frmFormaPagos_Load(object sender, EventArgs e)
        {

        }

        public void setData()
        {
            if (FormaPagoID != string.Empty)
            {
                callApiFormaPago.urlApi = CollectAPI.GetFormaPago;
                callApiFormaPago.CallGet(FormaPagoID);
                if (callApiFormaPago.objectResponse != null)
                {
                    txtDescripcion.Text = callApiFormaPago.objectResponse.Descripcion;
                    chkAceptaCambio.Checked = callApiFormaPago.objectResponse.AceptaCambio;
                    
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertFormaPago);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateFormaPago);
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
            MngApiFormaPago.urlApi = urlApi;
            MngApiFormaPago.objectRequest = formaPago;
            MngApiFormaPago.CallPost();
            result = MngApiFormaPago.objectResponse;
        }

        private void prepareData()
        {
            if (modo == Modo.Editar)
            {
                formaPago.ID = FormaPagoID;
            }
            formaPago.Descripcion = txtDescripcion.Text;
            formaPago.AceptaCambio = chkAceptaCambio.Checked;
            
        }
    
    }
}
