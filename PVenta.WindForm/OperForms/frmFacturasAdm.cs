using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
using PVenta.Utility;
using PVenta.WindForm.ApiCall;
using PVenta.WindForm.Define;
using PVenta.WindForm.GlobalInfo;
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
    public partial class frmFacturasAdm : FormGRLA
    {
        public viewLogin userApp = null;

        private CallApies<viewFacturaHeader, ApiFechaRango> callApiBuscaFacturas = new CallApies<viewFacturaHeader, ApiFechaRango>();
        
        private List<viewFacturaHeader> listFacturas;
        private List<viewDetalleGrid> listFacturaGrid;

        private decimal valOrdenPagado = 0, valSubTotal = 0, valDescuento = 0, valITBIS = 0, calcITBIS = 0;
        
        private string idFacturaSelected = string.Empty;
        private string idOrderSelected = string.Empty;

        public frmFacturasAdm()
        {
            InitializeComponent();
        }

        private void frmFacturasAdm_Load(object sender, EventArgs e)
        {
            dgvFacturaDetail.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
            dgvMesas.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
            
            dtpFechaIni.Format = DateTimePickerFormat.Custom;
            dtpFechaIni.CustomFormat = GeneralFormsSettings.FormatDatePicker;
            

            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.CustomFormat = GeneralFormsSettings.FormatDatePicker;
        }

        public void CargaDataFacturas()
        {
            int diasprevios = (gConfigSistema.configSistemaInfo.DiasFactura * -1);
            dtpFechaIni.Value = DateTime.Now.AddDays(diasprevios);
            CargaListMesas();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrarGridMesas();
        }

        private void filtrarGridMesas(bool recrearlista = false)
        {
            if (recrearlista)
            {
                CargaListMesas();
            }

            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString();
            string filtroText = txtFiltro.Text;
            if (callApiBuscaFacturas.listaResponse != null && textFiltroDefault != filtroText)
            {
                setDataSourceMesaGrid(filtroText);
            }
        }

        private void dtpFechaIni_ValueChanged(object sender, EventArgs e)
        {
            filtrarGridMesas(true);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            filtrarGridMesas(true);
        }

        private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idFacturaSelected = dgvMesas.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            cargaListFactura(idFacturaSelected);
        }

        private void cargaListFactura(string idFacturaSelected, bool soloCalcular = false)
        {
            CleanInfoGRLA();

            if (listFacturas != null)
            {
                viewFacturaHeader facturaSel = listFacturas.FirstOrDefault(x => x.ID == idFacturaSelected);
                List<viewFacturaDetail> facturaDetailSel = facturaSel.FacturaDetails.ToList();
                List<viewFacturaDetail> facturaDetailUpdated = new List<viewFacturaDetail>();
                foreach (viewFacturaDetail factDeta in facturaDetailSel)
                {
                    viewFacturaDetail factDetaCopy = factDeta.Clone() as viewFacturaDetail;

                    facturaDetailUpdated.Add(factDetaCopy);
                }

                //facturadoParcial(facturaDetailUpdated);

                listFacturaGrid = (from lDeta in facturaDetailUpdated
                                 orderby lDeta.Orden
                                 select new viewDetalleGrid
                                 {
                                     Producto = lDeta.producto.Nombre,
                                     Referencia = lDeta.producto.Referencia,
                                     Orden = lDeta.Orden,
                                     Cantidad = lDeta.Cantidad,
                                     Precio = lDeta.Precio,
                                     Total = lDeta.Cantidad * lDeta.Precio,
                                     ID = lDeta.ID
                                 }).ToList();

                valSubTotal = listFacturaGrid.Sum(x => x.Cantidad * x.Precio);
                valDescuento = (valSubTotal * (facturaSel.DescPorc / 100)) + facturaSel.DescMonto;
                calcITBIS = facturaSel.Itbis ? 1 : 0;
                valITBIS = (valSubTotal * (facturaSel.ItbisPorc / 100) * calcITBIS);

                if (!soloCalcular)
                {
                    muestraInfoResumen(facturaSel);
                }

            }
        }

        private void muestraInfoResumen(viewFacturaHeader facturaSel)
        {
            bool lpagadoVisible;
            dgvFacturaDetail.DataSource = listFacturaGrid;
            txtNoFactura.Text = "# " + facturaSel.NumFactura.ToString();
            txtFecha.Text = facturaSel.Fecha.ToString();
            txtCliente.Text = facturaSel.ClientePrincipal;
            txtMesa.Text = facturaSel.Mesa.Descripcion;


            txtSubTotal.Text = valSubTotal.ToString("C");
            txtDescuento.Text = valDescuento.ToString("C");
            txtITBIS.Text = valITBIS.ToString("C");
            txtTotal.Text = (valSubTotal - valDescuento + valITBIS).ToString("C");

            // Muestra la parte Pagada de la Orden Segun sus Facturas Relacionadas
            if (valOrdenPagado > 0)
            {
                decimal valRestante = ((valSubTotal - valDescuento + valITBIS) + valOrdenPagado);
                txtPagado.Text = valOrdenPagado.ToString("C");
                txtTotalORG.Text = valRestante.ToString("C");
                lpagadoVisible = true;
            }
            else
            {
                valOrdenPagado = 0;
                txtPagado.Text = valOrdenPagado.ToString("C");
                lpagadoVisible = false;
            }

            txtPagado.Visible = lpagadoVisible;
            lblPagado.Visible = lpagadoVisible;
            txtTotalORG.Visible = false;
            lblTotalORG.Visible = false;
        }

        private void CleanInfoGRLA()
        {
            // lblInfo.Visible = false;
            valOrdenPagado = 0;
            //idOrderSelected = string.Empty;
        }

        private void CargaListMesas()
        {

            ApiFechaRango param = new ApiFechaRango();
            param.FechaInicio = dtpFechaIni.Value;
            param.FechaFin = dtpFechaFin.Value;

            callApiBuscaFacturas.urlApi = CollectAPI.GetFacturasByFechas;
            callApiBuscaFacturas.objectRequest = param;
            callApiBuscaFacturas.CallPostList();
               
            listFacturas = callApiBuscaFacturas.listaResponse.ToList();
            excludeFacturaFecha();
            setDataSourceMesaGrid();
        }

        private void excludeFacturaFecha()
        {
            foreach (viewFacturaHeader facturaReview in callApiBuscaFacturas.listaResponse)
            {
                // Codigo para excluir las Factura fuera del rango de fecha
                bool excluirFactura = facturaReview.Fecha > dtpFechaFin.Value && facturaReview.Fecha < dtpFechaIni.Value;
                if (excluirFactura)
                {
                    listFacturas.Remove(facturaReview);
                }
            }
        }

        private void setDataSourceMesaGrid()
        {
            if (listFacturas != null && listFacturas.Count > 0)
            {
                var listMesas = (from lmes in listFacturas
                                 orderby lmes.Fecha, lmes.FechaRegistro
                                 select new
                                 {
                                     Mesa = lmes.Mesa.Descripcion + " - " + lmes.ClientePrincipal +
                                              " [" + lmes.NumFactura + "]",
                                     lmes.ID
                                 }).ToList();
                dgvMesas.DataSource = listMesas;
            }
        }

        private void setDataSourceMesaGrid(string filtroText)
        {
            if (listFacturas != null)
            {
                var listMesas = (from lmes in listFacturas
                                 orderby lmes.Fecha, lmes.FechaRegistro
                                 where lmes.Mesa.Descripcion.ToLower().Contains(filtroText.ToLower()) ||
                                       lmes.ClientePrincipal.ToLower().Contains(filtroText.ToLower()) ||
                                       lmes.NumFactura.ToString().Contains(filtroText)
                                 select new
                                 {
                                     Mesa = lmes.Mesa.Descripcion + " - " + lmes.ClientePrincipal +
                                             " [" + lmes.NumFactura + "]",
                                     lmes.ID
                                 }).ToList();
                dgvMesas.DataSource = listMesas;

                // Remover todo y limpiar
                listFacturaGrid = new List<viewDetalleGrid>();
                dgvFacturaDetail.DataSource = listFacturaGrid;
            }
        }




    }
}
