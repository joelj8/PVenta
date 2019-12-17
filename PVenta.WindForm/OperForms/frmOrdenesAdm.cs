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
    public partial class frmOrdenesAdm : FormGRLA
    {
        public viewLogin userApp = null;
        private CallApies<viewOrderHeader, ApiOrderHeader> callApiOrdenes = new CallApies<viewOrderHeader, ApiOrderHeader>();
        private CallApies<viewFacturaHeader, ApiFacturaHeader> callApiFacturas = new CallApies<viewFacturaHeader, ApiFacturaHeader>();
        private List<viewOrderHeader> listOrdenes;
        private decimal valOrdenPagado = 0, valSubTotal = 0, valDescuento = 0, valITBIS = 0, calcITBIS = 0;
        private List<viewDetalleGrid> listOrderGrid;
        private string idOrderSelected = string.Empty;
        public frmOrdenesAdm()
        {
            InitializeComponent();
        }

        private void frmOrdenesAdm_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
            dgvMesas.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
            
        }

        public void CargaDataOrdenes()
        {
            CargaListMesas();
        }

        private void CargaListMesas()
        {
            callApiOrdenes.urlApi = CollectAPI.GetOrders;
            callApiOrdenes.CallGetList();
            listOrdenes = callApiOrdenes.listaResponse.ToList();
            excludePaidOrder();
            setDataSourceMesaGrid();
        }

        private void excludePaidOrder()
        {
            foreach(viewOrderHeader orderReview in callApiOrdenes.listaResponse)
            {
                
                // Codigo para excluir las Ordenes que fueron Pagadas
                cargaListOrden(orderReview.ID, true);
                if (valSubTotal <= 0)
                {
                    listOrdenes.Remove(orderReview);
                }
            }
        }

        private void setDataSourceMesaGrid()
        {
            if (listOrdenes != null)
            {
                var listMesas = (from lmes in listOrdenes
                                 orderby lmes.Fecha, lmes.FechaRegistro
                                 select new { Mesa = lmes.Mesa.Descripcion + " - "+ lmes.ClientePrincipal +
                                              " ["+lmes.NumOrden+"]", lmes.ID }).ToList();
                dgvMesas.DataSource = listMesas;
            }
        }

        private void setDataSourceMesaGrid(string filtroText)
        {
            if (listOrdenes != null)
            {
                var listMesas = (from lmes in listOrdenes
                                 orderby lmes.Fecha,lmes.FechaRegistro
                                 where lmes.Mesa.Descripcion.ToLower().Contains(filtroText.ToLower()) ||
                                       lmes.ClientePrincipal.ToLower().Contains(filtroText.ToLower()) ||
                                       lmes.NumOrden.ToString().Contains(filtroText)
                                 select new { Mesa = lmes.Mesa.Descripcion + " - " + lmes.ClientePrincipal +
                                             " [" + lmes.NumOrden + "]", lmes.ID }).ToList();
                dgvMesas.DataSource = listMesas;
            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void cargaListOrden(string idOrdenSelected, bool soloCalcular = false)
        {
            CleanInfoGRLA();
            
            if (listOrdenes != null)
            {
                viewOrderHeader orderSel = listOrdenes.FirstOrDefault(x => x.ID == idOrdenSelected);
                List<viewOrderDetail> orderDetailSel = orderSel.OrderDetails.ToList();
                List<viewOrderDetail> orderDetailUpdated = new List<viewOrderDetail>();
                foreach (viewOrderDetail ordDeta in orderDetailSel)
                {
                    viewOrderDetail ordDetaCopy = ordDeta.Clone() as viewOrderDetail;
                   
                    orderDetailUpdated.Add(ordDetaCopy);
                    

                }

                facturadoParcial(orderDetailUpdated);

                listOrderGrid = (from lDeta in orderDetailUpdated
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

                valSubTotal = listOrderGrid.Sum(x => x.Cantidad * x.Precio);
                valDescuento = (valSubTotal * (orderSel.DescPorc / 100)) + orderSel.DescMonto;
                calcITBIS = orderSel.Itbis ? 1 : 0;
                valITBIS = (valSubTotal * (orderSel.ItbisPorc / 100) * calcITBIS);

                if (!soloCalcular)
                {
                    muestraInfoResumen(orderSel);
                }

            }
        }

        private void CleanInfoGRLA()
        {
            lblInfo.Visible = false;
            valOrdenPagado = 0;
            //idOrderSelected = string.Empty;
        }

        private void muestraInfoResumen(viewOrderHeader orderSel)
        {
            bool lpagadoVisible;
            dgvOrderDetail.DataSource = listOrderGrid;
            txtNoOrden.Text = "# " + orderSel.NumOrden;
            txtFecha.Text = orderSel.Fecha.ToString();
            txtCliente.Text = orderSel.ClientePrincipal;
            txtMesa.Text = orderSel.Mesa.Descripcion;


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

        private List<viewOrderDetail> facturadoParcial(List<viewOrderDetail> orderDetailSel)
        {
            string idHOrder = orderDetailSel.FirstOrDefault().OrderHID;
            
            callApiFacturas.urlApi = CollectAPI.GetFacturasByOrder;
            callApiFacturas.CallGetList(idHOrder);
            //listOrdenes = callApiOrdenes.listaResponse.ToList();

            decimal descMontoByFactura = 0, descPorcByFactura=0, itbisPorcByFactura =0;

            //Paso 1- Recorrer el Detalle de la Orden
            foreach (viewOrderDetail ordDeta in orderDetailSel)
            {
                string idorddetail = ordDeta.ID;

                // Recorrer las Facturas relacionadas a la Orden
                foreach (viewFacturaHeader factByOrder in callApiFacturas.listaResponse.ToList())
                {
                    descMontoByFactura = factByOrder.DescMonto;
                    descPorcByFactura = (factByOrder.DescPorc / 100);
                    itbisPorcByFactura = (factByOrder.ItbisPorc / 100);
                    List<viewFacturaDetail> fdetfactlist = factByOrder.FacturaDetails.ToList();
                    // Recorrer el Detalle de Factura relacionada a la Orden para descontar cantidades pagadas
                    foreach (viewFacturaDetail fdetfact in fdetfactlist)
                    {
                        if (idorddetail == fdetfact.OrderDID)
                        {
                            ordDeta.Cantidad -= fdetfact.Cantidad;
                            // Valor del Monto Pagado (Incluye el Descuento de la Factura y su ITBIS)
                            decimal pagoByProduct = (fdetfact.Cantidad * fdetfact.Precio);
                            pagoByProduct -= pagoByProduct >= descMontoByFactura ? descMontoByFactura : pagoByProduct;
                            descMontoByFactura -= pagoByProduct >= descMontoByFactura ? descMontoByFactura : pagoByProduct;
                            pagoByProduct -= pagoByProduct == 0 ? 0 : (pagoByProduct * descPorcByFactura);
                            pagoByProduct += (pagoByProduct * itbisPorcByFactura);
                            valOrdenPagado += pagoByProduct ;
                        }
                    }
                }
            }

            return orderDetailSel;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString();
            string filtroText = txtFiltro.Text;
            if (callApiOrdenes.listaResponse != null && textFiltroDefault != filtroText)
            {
                setDataSourceMesaGrid(filtroText);

            }
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblInfo.Text = string.Empty;
                lblInfo.Visible = false;
                string idOrderDetailGrid = dgvOrderDetail.Rows[e.RowIndex].Cells["ColIDGrid"].Value.ToString();
                viewOrderHeader orderSelected = callApiOrdenes.listaResponse.FirstOrDefault(x => x.ID == this.idOrderSelected);
                if (orderSelected != null)
                {
                    int cantidadOriginal = (int)orderSelected.OrderDetails.FirstOrDefault(x => x.ID == idOrderDetailGrid).Cantidad;
                    decimal cantidadPendiente = decimal.Parse(dgvOrderDetail.Rows[e.RowIndex].Cells["ColCant"].Value.ToString());
                    string nombProducto = dgvOrderDetail.Rows[e.RowIndex].Cells["ColProducto"].Value.ToString();
                    if (cantidadPendiente != cantidadOriginal)
                    {
                        lblInfo.Text = string.Format("{0} cantidad previo al pago fue {1}", nombProducto, cantidadOriginal);
                        lblInfo.Visible = true;
                    }
                }
            }
            
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmOrdenes fOrdenes = new frmOrdenes();
            fOrdenes.modo = Modo.Agregar;
            fOrdenes.userApp = this.userApp;
            fOrdenes.InitNewOrder();

            fOrdenes.ShowDialog();
            fOrdenes.Dispose();
            CargaDataOrdenes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(idOrderSelected != string.Empty)
            {
                frmOrdenes fOrdenes = new frmOrdenes();
                fOrdenes.modo = Modo.Editar;
                fOrdenes.OrderID = idOrderSelected;
                fOrdenes.userApp = this.userApp;
                fOrdenes.InitEditOrder();

                fOrdenes.ShowDialog();
                fOrdenes.Dispose();
                CargaDataOrdenes();
                cargaListOrden(idOrderSelected);
            }
        }


        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            textFiltroMng("E");
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            textFiltroMng("L");
        }

        private void textFiltroMng(string modo, bool reiniciar = false)
        {
            if (reiniciar)
            {
                txtFiltro.Text = string.Empty;
            }

            string txtvalue = txtFiltro.Text.ToString();
            string textCompara = modo == "L" ? string.Empty : Properties.Settings.Default.TextoFiltro.ToString();
            string textAsigna = modo == "L" ? Properties.Settings.Default.TextoFiltro.ToString() : string.Empty;

            if (txtvalue == textCompara)
            {
                txtFiltro.Text = textAsigna;
            }

            if (modo == "L" && txtFiltro.Text == textAsigna)
            {
                txtFiltro.Font = new Font(txtFiltro.Font, FontStyle.Italic);
                txtFiltro.ForeColor = Color.Gray;
            }
            else
            {
                txtFiltro.Font = new Font(txtFiltro.Font, FontStyle.Regular);
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idOrderSelected = dgvMesas.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
                if (idOrderSelected != string.Empty)
                {
                    cargaListOrden(idOrderSelected);
                }
            }
            
            
        }
    }
}
