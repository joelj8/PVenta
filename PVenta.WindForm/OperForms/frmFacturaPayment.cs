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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            viewFacturaPaymentGrid regPago = new viewFacturaPaymentGrid();
            regPago.FormaPagoId = cboFormaPago.SelectedItem.ToString();
            regPago.FormaPago = cboFormaPago.Text;
            regPago.MontoPago = numMontPago.Value;
            regPago.InfoPago = txtInfoPago.Text;
            regPago.MontoDevolver = montTotal > numMontPago.Value ? 0 : numMontPago.Value - montTotal;

            facturaPagoGrid.Add(regPago);


            setDataPagoGrid();
            clearInfoPago(true);

            cboFormaPago.Focus();
        }

        private void setDataPagoGrid()
        {
            if (facturaPagoGrid != null)
            {
                var listGrid = facturaPagoGrid.OrderBy(s => s.FormaPago).ToList();
                this.dgvFacturaPagos.DataSource = listGrid;
            }
            calcPagoInfo();
        }

        private void clearInfoPago(bool hardclear)
        {
            numMontPago.Value = 0;
            cboFormaPago.SelectedItem = "";
            txtInfoPago.Clear();

        }

        private void calcPagoInfo()
        {
            decimal totalPago = facturaPagoGrid.Sum(x => x.MontoPago);
            txtDevolver.Text = (montTotal > totalPago ? 0 : totalPago - montTotal).ToString("c");
        }
    }
}
