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
    public partial class frmFacturasAdm : FormGRLA
    {
        public viewLogin userApp = null;
        /*
        private CallApies<viewOrderHeader, ApiOrderHeader> callApiOrdenes = new CallApies<viewOrderHeader, ApiOrderHeader>();
        private CallApies<viewFacturaHeader, ApiFacturaHeader> callApiFacturas = new CallApies<viewFacturaHeader, ApiFacturaHeader>();
        
        private List<viewOrderGrid> listOrderGrid;
        */

        private CallApies<viewFacturaHeader, ApiFacturaHeader> callApiFacturas = new CallApies<viewFacturaHeader, ApiFacturaHeader>();
        private List<viewFacturaHeader> listFacturas;

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
            CargaListMesas();
        }

        private void CargaListMesas()
        {
            callApiFacturas.urlApi = CollectAPI.GetFacturas;
            callApiFacturas.CallGetList();
            listFacturas = callApiFacturas.listaResponse.ToList();
            excludeFacturaFecha();
            setDataSourceMesaGrid();
        }

        private void excludeFacturaFecha()
        {
            foreach (viewFacturaHeader facturaReview in callApiFacturas.listaResponse)
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
            if (listFacturas != null)
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
            }
        }




    }
}
