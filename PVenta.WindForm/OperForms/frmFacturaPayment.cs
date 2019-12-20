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

namespace PVenta.WindForm.OperForms
{
    public partial class frmFacturaPayment : FormGRLA
    {
        public decimal montSubTotal { get; set; }
        public decimal montDescuento { get; set; }
        public decimal montITBIS { get; set; }
        public decimal montServicio { get; set; }
        public decimal montTotal { get; set; }

        public viewLogin userApp = null;

        private CallApies<viewFormaPago, ApiFormaPago> callApiFormaPago = new CallApies<viewFormaPago, ApiFormaPago>();

        List<viewFacturaPaymentGrid> facturaPagoGrid = new List<viewFacturaPaymentGrid>();
        List<viewFacturaPayment> facturaPagos = null;

        public frmFacturaPayment()
        {
            InitializeComponent();
        }

        private void frmFacturaPayment_Load(object sender, EventArgs e)
        {

        }

        public void setDataPago()
        {
            txtSubTotal.Text = montSubTotal.ToString("c");
            txtDescuento.Text = montDescuento.ToString("c");
            txtITBIS.Text = montITBIS.ToString("c");
            txtServicio.Text = montServicio.ToString("c");
            txtTotal.Text = montTotal.ToString("c");
            txtDevolver.Text = decimal.Zero.ToString("c");

            dgvFacturaPagos.DataSource = facturaPagoGrid;

            setDataComboFormaPago();
        }

        private void setDataComboFormaPago()
        {
            callApiFormaPago.urlApi = CollectAPI.GetFormaPagos;
            callApiFormaPago.CallGetList();
            if (callApiFormaPago.listaResponse != null)
            {
                BindingSource bdS = new BindingSource();
                bdS.DataSource = callApiFormaPago.listaResponse;
                cboFormaPago.DataSource = bdS.DataSource;

                cboFormaPago.DisplayMember = "Descripcion";
                cboFormaPago.ValueMember = "ID";
            }
        }
    }
}
