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
    public partial class frmMonedas : FormGRLA
    {
        public Modo modo;

        public string MonedaID { get; set; }
        private viewMessageApp result = null;
        private ApiMoneda moneda = new ApiMoneda();

        private CallApies<viewMoneda, ApiMoneda> callApiMoneda = new CallApies<viewMoneda, ApiMoneda>();
        private CallApies<viewMessageApp, ApiMoneda> MngApiMoneda = new CallApies<viewMessageApp, ApiMoneda>();

        public frmMonedas()
        {
            InitializeComponent();
        }

        private void frmMonedas_Load(object sender, EventArgs e)
        {

        }

        internal void setData()
        {
            if (MonedaID != string.Empty)
            {
                callApiMoneda.urlApi = CollectAPI.GetMoneda;
                callApiMoneda.CallGet(MonedaID);
                if (callApiMoneda.objectResponse != null)
                {
                    txtDescripcion.Text = callApiMoneda.objectResponse.Descripcion;
                    numValor.Value = callApiMoneda.objectResponse.Valor;
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertMoneda);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateMoneda);
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
            MngApiMoneda.urlApi = urlApi;
            MngApiMoneda.objectRequest = moneda;
            MngApiMoneda.CallPost();
            result = MngApiMoneda.objectResponse;
        }

        private void prepareData()
        {
            if (modo == Modo.Editar)
            {
                moneda.ID = MonedaID;
            }
            moneda.Descripcion = txtDescripcion.Text;
            moneda.Valor = decimal.Parse(numValor.Value.ToString());
        }
    }
}
