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
    public partial class frmFacturas : FormGRLA
    {

        public viewLogin userApp = null;
        public Modo modo { get; set; }
        public string FacturaID { get; set; } = string.Empty;
        public string FacturaIDCreada { get; set; } = string.Empty;
        private string OrdenID { get; set; } = string.Empty;

        private List<viewDetalleGrid> listOrdenDetailORG = null;
        private string IDOrdenDetail { get; set; } = string.Empty;

        private CallApies<viewUsuario, ApiUsuario> callApiUsuario = new CallApies<viewUsuario, ApiUsuario>();
        private CallApies<viewMesa, ApiMesa> callApiMesa = new CallApies<viewMesa, ApiMesa>();
        private CallApies<viewProducto, ApiProducto> callApiProducto = new CallApies<viewProducto, ApiProducto>();

        private CallApies<viewOrderHeader, ApiOrderHeader> callApiOrden = new CallApies<viewOrderHeader, ApiOrderHeader>();
        private CallApies<viewFacturaHeader, ApiFacturaHeader> callApiFactura = new CallApies<viewFacturaHeader, ApiFacturaHeader>();
        private List<viewFacturaDetailGrid> gridFacturaDetail = new List<viewFacturaDetailGrid>();
        private ApiFacturaHeader dataFacturaHeader;
        private ApiOrderHeader dataOrderHeader;

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            dgvFacturaDetail.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
        }

        public void InitNewFactura()
        {
            setDataCombo();
            txtFecha.Text = DateTime.Now.ToString();
            cboUsuario.SelectedValue = this.userApp.ID;
            chkITBIS.Checked = gConfigSistema.configSistemaInfo.CalcITBIS;
            chkServicio.Checked = gConfigSistema.configSistemaInfo.CalcServicio;
        }

        private void setDataCombo()
        {
            callApiUsuario.urlApi = CollectAPI.GetUsuarios;
            callApiUsuario.CallGetList();
            if (callApiUsuario.listaResponse != null)
            {
                BindingSource bdS = new BindingSource();
                bdS.DataSource = callApiUsuario.listaResponse;
                cboUsuario.DataSource = bdS.DataSource;

                cboUsuario.DisplayMember = "Nombre";
                cboUsuario.ValueMember = "ID";
            }

            callApiMesa.urlApi = CollectAPI.GetMesas;
            callApiMesa.CallGetList();
            if (callApiMesa.listaResponse != null)
            {
                BindingSource bdS = new BindingSource();
                bdS.DataSource = callApiMesa.listaResponse;
                cboMesa.DataSource = bdS.DataSource;

                cboMesa.DisplayMember = "Descripcion";
                cboMesa.ValueMember = "ID";
            }

            callApiProducto.urlApi = CollectAPI.GetProductos;
            callApiProducto.CallGetList();
        }

        public void InitEditFactura()
        {
            dataFacturaHeader = new ApiFacturaHeader();

            setDataCombo();


            callApiFactura.urlApi = CollectAPI.GetFactura;
            callApiFactura.CallGet(this.FacturaID);

            txtFecha.Text = callApiFactura.objectResponse.Fecha.ToString();
            chkITBIS.Checked = callApiFactura.objectResponse.Itbis;
            cboUsuario.SelectedValue = callApiFactura.objectResponse.UserId;
            txtClientePrincipal.Text = callApiFactura.objectResponse.ClientePrincipal;
            numDescMonto.Value = callApiFactura.objectResponse.DescMonto;
            numDescPorc.Value = callApiFactura.objectResponse.DescPorc;
            cboMesa.SelectedValue = callApiFactura.objectResponse.MesaId;
            chkServicio.Checked = callApiFactura.objectResponse.Servicio;

            gridFacturaDetail = new List<viewFacturaDetailGrid>();

            foreach (viewFacturaDetail factDetail in callApiFactura.objectResponse.FacturaDetails)
            {
                viewFacturaDetailGrid dataOrdDetailGrid = new viewFacturaDetailGrid();
                dataOrdDetailGrid.ID = factDetail.ID;
                dataOrdDetailGrid.FacturaHID = dataFacturaHeader.ID;
                dataOrdDetailGrid.ImpComanda = factDetail.ImpComanda;
                dataOrdDetailGrid.Orden = factDetail.Orden;
                dataOrdDetailGrid.Precio = factDetail.Precio;
                dataOrdDetailGrid.ProductoID = factDetail.ProductoID;
                dataOrdDetailGrid.producto = factDetail.producto.Nombre;
                dataOrdDetailGrid.Referencia = factDetail.producto.Referencia;
                dataOrdDetailGrid.Cantidad = factDetail.Cantidad;
                dataOrdDetailGrid.ClientePedido = factDetail.ClientePedido;
                dataOrdDetailGrid.Impreso = factDetail.Impreso;
                dataOrdDetailGrid.Inactivo = factDetail.Inactivo;
                gridFacturaDetail.Add(dataOrdDetailGrid);

            }

            setFacturaDetail();
        }

        public void InitFacturaByOrder(string idOrderToFactura, List<viewDetalleGrid> listOrden)
        {
            this.OrdenID = idOrderToFactura;
            this.listOrdenDetailORG = listOrden;
            dataFacturaHeader = new ApiFacturaHeader();
            dataOrderHeader = new ApiOrderHeader();

            setDataCombo();

            this.callApiOrden.urlApi = CollectAPI.GetOrder;
            this.callApiOrden.CallGet(this.OrdenID);

            
            txtFecha.Text = DateTime.Now.ToString();
            chkITBIS.Checked = callApiOrden.objectResponse.Itbis;
            cboUsuario.SelectedValue = callApiOrden.objectResponse.UserId;
            txtClientePrincipal.Text = callApiOrden.objectResponse.ClientePrincipal;
            numDescMonto.Value = callApiOrden.objectResponse.DescMonto;
            numDescPorc.Value = callApiOrden.objectResponse.DescPorc;
            cboMesa.SelectedValue = callApiOrden.objectResponse.MesaId;
            chkServicio.Checked = callApiOrden.objectResponse.Servicio;

            gridFacturaDetail = new List<viewFacturaDetailGrid>();
            /**/
            foreach (viewDetalleGrid factDetail in this.listOrdenDetailORG)
            {
                if (factDetail.Cantidad > 0)
                {
                    viewFacturaDetailGrid dataOrdDetailGrid = new viewFacturaDetailGrid();
                    //dataOrdDetailGrid.ID = factDetail.ID;
                    //dataOrdDetailGrid.FacturaHID = dataFacturaHeader.ID;
                    //dataOrdDetailGrid.ImpComanda = factDetail.ImpComanda;
                    //dataOrdDetailGrid.ClientePedido = factDetail.ClientePedido;
                    //dataOrdDetailGrid.Impreso = factDetail.Impreso;
                    //dataOrdDetailGrid.Inactivo = factDetail.Inactivo;
                    /* */

                    dataOrdDetailGrid.ID = Guid.NewGuid().ToString();
                    dataOrdDetailGrid.OrderDID = factDetail.ID;
                    dataOrdDetailGrid.Orden = factDetail.Orden;
                    dataOrdDetailGrid.Precio = factDetail.Precio;
                    dataOrdDetailGrid.ProductoID = factDetail.ProductoID;
                    dataOrdDetailGrid.producto = factDetail.Producto;
                    dataOrdDetailGrid.Referencia = factDetail.Referencia;
                    dataOrdDetailGrid.Cantidad = factDetail.Cantidad;

                    gridFacturaDetail.Add(dataOrdDetailGrid);
                }
            }
            setFacturaDetail();
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                findProductByReferencia();
            }
        }

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
              findProductByReferencia();
        }

        private void findProductByReferencia()
        {
            string findProductRef = txtReferencia.Text.Trim().ToLower();
            if (findProductRef != string.Empty)
            {
                clearInfoProduct();
                if (callApiProducto.listaResponse != null)
                {
                    viewProducto ProductSelect = (from lprod in callApiProducto.listaResponse
                                                  where lprod.Referencia.Trim().ToLower().Equals(findProductRef) &&
                                                        !lprod.esAdicional
                                                  orderby lprod.Referencia
                                                  select lprod).FirstOrDefault();

                    setProductoInfo(ProductSelect);

                }
            }
        }

        private viewProducto findProductByID(string idProducto)
        {
            viewProducto productSelect = null;
            if (callApiProducto.listaResponse != null)
            {
                productSelect = (from lprod in callApiProducto.listaResponse
                                 where lprod.ID == idProducto
                                 select lprod).FirstOrDefault();
            }
            return productSelect;
        }

        private void setProductoInfo(viewProducto productSelect)
        {
            if (productSelect != null)
            {
                txtProducto.Text = productSelect.Nombre;
                numCant.Value = 1;
                numPrecio.Value = productSelect.Precio;
                txtID.Text = productSelect.ID;

                calcTotalProductoInfo();
                numCant.Focus();
            }
        }

        private void calcTotalProductoInfo()
        {
            numTotal.Value = (numCant.Value * numPrecio.Value);
        }

        private void clearInfoProduct(bool hardClean = false)
        {
            if (hardClean)
            {
                txtReferencia.Text = string.Empty;
                txtID.Text = string.Empty;
            }
            txtProducto.Text = string.Empty;
            numCant.Value = decimal.Zero;
            numPrecio.Value = decimal.Zero;
            numTotal.Value = decimal.Zero;
        }

        private void numCant_ValueChanged(object sender, EventArgs e)
        {
            calcTotalProductoInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            callApiProducto.urlApi = CollectAPI.GetProducto;
            callApiProducto.CallGet(txtID.Text);
            if (callApiProducto.objectResponse != null)
            {
                viewFacturaDetailGrid newOrdDetail = new viewFacturaDetailGrid();

                newOrdDetail.ID = Guid.NewGuid().ToString();
                newOrdDetail.ProductoID = txtID.Text;
                newOrdDetail.ClientePedido = string.Empty;

                newOrdDetail.Orden = nextOrdenNo(gridFacturaDetail);
                newOrdDetail.FacturaHID = string.Empty;

                newOrdDetail.Cantidad = numCant.Value;
                newOrdDetail.Precio = numPrecio.Value;
                newOrdDetail.Referencia = callApiProducto.objectResponse.Referencia;
                newOrdDetail.ImpComanda = (callApiProducto.objectResponse.ImpComanda ?
                                            callApiProducto.objectResponse.ImpComanda :
                                          callApiProducto.objectResponse.Categoria.ImpComanda);
                newOrdDetail.producto = callApiProducto.objectResponse.Nombre;

                gridFacturaDetail.Add(newOrdDetail);
                setFacturaDetail();
                clearInfoProduct(true);
                txtReferencia.Focus();
            }
        }

        private decimal nextOrdenNo(List<viewFacturaDetailGrid> FacturaDetailEvalua)
        {
            decimal resultado = 0;
            if (FacturaDetailEvalua != null && FacturaDetailEvalua.Count > 0)
            {
                resultado = (from ordDeta in FacturaDetailEvalua
                             where (int)ordDeta.Orden - ordDeta.Orden == 0
                             select ordDeta.Orden).Max();
            }

            resultado += 1;
            return resultado;
        }

        private void setFacturaDetail()
        {
            if (gridFacturaDetail != null)
            {
                   var listGrid = gridFacturaDetail.OrderBy(s => s.Orden).ToList();
                this.dgvFacturaDetail.DataSource = listGrid;
            }
            calculateFactura();
        }

        private void calculateFactura()
        {
            decimal valPorcGRL = 0;
            decimal valSubTotal = gridFacturaDetail.Sum(x => x.Total);

            decimal valDescuento = (numDescMonto.Value + (valSubTotal * (numDescPorc.Value / 100)));
            valPorcGRL = chkITBIS.Checked ? (gConfigSistema.configSistemaInfo.PorcITBIS / 100) : 0;
            decimal valITBIS = (valSubTotal - valDescuento) * valPorcGRL;
            valPorcGRL = chkServicio.Checked ? (gConfigSistema.configSistemaInfo.PorcServicio / 100) : 0;
            decimal valServicio = (valSubTotal - valDescuento) * valPorcGRL;
            decimal valTotal = valSubTotal - valDescuento + valITBIS + valServicio;

            txtSubTotal.Text = valSubTotal.ToString("c");
            txtDescuento.Text = valDescuento.ToString("c");
            txtITBIS.Text = valITBIS.ToString("c");
            txtServicio.Text = valServicio.ToString("c");
            txtTotal.Text = valTotal.ToString("c");
        }

        private void dgvFacturaDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                int dgvCountSelect = dgvFacturaDetail.GetCellCount(DataGridViewElementStates.Selected);
                if (dgvCountSelect > 0)
                {
                    int dgvRowSelect = dgvFacturaDetail.SelectedCells[0].RowIndex;
                    string idFacturaGrid = dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColID"].Value.ToString();
                    string productoID = dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColProductoID"].Value.ToString();
                    string nombreProducto = dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColProducto"].Value.ToString();
                    string cantidadProducto = dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColCant"].Value.ToString();
                    bool infoImpreso = (bool)dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColImpreso"].Value;
                    viewProducto productoSelect = findProductByID(productoID);
                    if (!infoImpreso && !productoSelect.esAdicional)
                    {
                        DialogResult respuesta = MessageBox.Show(string.Format("Desea eliminar el producto {0} Cantidad {1}?", nombreProducto, cantidadProducto), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.Yes)
                        {
                            eliminaRecord(idFacturaGrid);
                        }
                    }
                }

            } 
            
        }

        private void eliminaRecord(string idFacturaGrid)
        {
            if (idFacturaGrid != null && idFacturaGrid != string.Empty)
            {
                viewFacturaDetailGrid factDetElimina = (from gODElim in gridFacturaDetail
                                                     where gODElim.ID == idFacturaGrid
                                                     select gODElim).FirstOrDefault();

                if (factDetElimina != null)
                {
                    gridFacturaDetail.Remove(factDetElimina);

                    decimal noOrdenRelacionado = decimal.Truncate(factDetElimina.Orden);
                    List<viewFacturaDetailGrid> factDetaEliminaAdicionales = (from goElimAdic in gridFacturaDetail
                                                                           where (int)goElimAdic.Orden == noOrdenRelacionado
                                                                           select goElimAdic).ToList();

                    foreach (viewFacturaDetailGrid factDetaElimAdicional in factDetaEliminaAdicionales)
                    {
                        gridFacturaDetail.Remove(factDetaElimAdicional);
                    }


                    setFacturaDetail();
                }
            }
        }

        private void numCant_Enter(object sender, EventArgs e)
        {
            numCant.Select(0, numCant.Text.Length);
        }

        private void numCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdd.Focus();
            }
        }

        private void chkITBIS_CheckedChanged(object sender, EventArgs e)
        {
            calculateFactura();
        }

        private void numDescMonto_Validated(object sender, EventArgs e)
        {
            calculateFactura();
        }

        private void numDescPorc_Validated(object sender, EventArgs e)
        {
            calculateFactura();
        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            calculateFactura();
        }

        private void dgvFacturaDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal numOrdenPadre = decimal.Parse(dgvFacturaDetail.Rows[e.RowIndex].Cells["ColOrden"].Value.ToString());
            string idProducto = dgvFacturaDetail.Rows[e.RowIndex].Cells["ColProductoID"].Value.ToString();
            string columnClick = dgvFacturaDetail.Columns[e.ColumnIndex].HeaderText.ToString();

            switch (columnClick.ToUpper())
            {
                case "AGREGAR":
                    callAgregarAdicional(idProducto, numOrdenPadre);
                    break;
                case "DIVIDIR":
                    callDividir();
                    break;
                default:
                    break;
            }
        }

        private void callDividir()
        {
            throw new NotImplementedException();
        }

        private void callAgregarAdicional(string idProducto, decimal numOrdenPadre)
        {
            viewProducto checkProducto = findProductByID(idProducto);

            if (checkProducto == null || !checkProducto.permiteAdicional)
            {
                string nombProducto = checkProducto == null ? string.Empty : checkProducto.Nombre;

                MessageBox.Show(string.Format("El producto '{0}' no permite agregar productos adicionales.", nombProducto),
                           this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmAdicional fAdicional = new frmAdicional();
                fAdicional.TipoForm = TipoForm.Factura;
                fAdicional.numOrden = numOrdenPadre;
                fAdicional.gridFacturaDetailMng = gridFacturaDetail;
                fAdicional.setDataAdicionalFactura();
                fAdicional.ShowDialog();
                fAdicional.Dispose();
                setFacturaDetail();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (prepareData())
            {
                if (this.modo == Modo.Agregar)
                {
                    callApiFactura.urlApi = CollectAPI.InsertFactura;

                }
                else if (this.modo == Modo.Editar)
                {
                    callApiFactura.urlApi = CollectAPI.UpdateFactura;
                }

                callApiFactura.objectRequest = dataFacturaHeader;
                callApiFactura.CallPost();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar de grabar la información", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool prepareData()
        {
            bool resultPrepare = false;
            try
            {
                dataFacturaHeader = new ApiFacturaHeader();

                if (this.modo == Modo.Agregar)
                {
                    dataFacturaHeader.FechaRegistro = DateTime.Now;
                    dataFacturaHeader.ID = Guid.NewGuid().ToString();
                    dataFacturaHeader.ItbisPorc = gConfigSistema.configSistemaInfo.PorcITBIS;
                    dataFacturaHeader.ServicioPorc = gConfigSistema.configSistemaInfo.PorcServicio;
                    dataFacturaHeader.UserId = userApp.ID;
                    dataFacturaHeader.OrderHID = this.OrdenID;
                    this.FacturaIDCreada = dataFacturaHeader.ID;
                }
                else
                {
                    callApiFactura.urlApi = CollectAPI.GetFactura;
                    callApiFactura.CallGet(this.FacturaID);
                    dataFacturaHeader.FechaRegistro = callApiFactura.objectResponse.FechaRegistro;
                    dataFacturaHeader.ID = callApiFactura.objectResponse.ID;
                    dataFacturaHeader.ItbisPorc = callApiFactura.objectResponse.ItbisPorc;
                    dataFacturaHeader.ServicioPorc = callApiFactura.objectResponse.ServicioPorc;
                    dataFacturaHeader.UserId = callApiFactura.objectResponse.UserId;
                    dataFacturaHeader.OrderHID = callApiFactura.objectResponse.OrderHID;
                }

                dataFacturaHeader.ClientePrincipal = txtClientePrincipal.Text;
                dataFacturaHeader.DescMonto = numDescMonto.Value;
                dataFacturaHeader.DescPorc = numDescPorc.Value;
                dataFacturaHeader.Fecha = DateTime.Parse(txtFecha.Text);
                dataFacturaHeader.Itbis = chkITBIS.Checked;
                dataFacturaHeader.MesaId = cboMesa.SelectedValue.ToString();
                dataFacturaHeader.Servicio = chkServicio.Checked;

                dataFacturaHeader.FacturaDetails = new List<ApiFacturaDetail>();

                foreach (viewFacturaDetailGrid factDetail in gridFacturaDetail)
                {
                    if (factDetail.Cantidad > 0)
                    {
                        ApiFacturaDetail dataFacturaDetail = new ApiFacturaDetail();
                        dataFacturaDetail.ID = factDetail.ID;
                        dataFacturaDetail.ImpComanda = factDetail.ImpComanda;
                        dataFacturaDetail.Orden = factDetail.Orden;
                        dataFacturaDetail.FacturaHID = dataFacturaHeader.ID;
                        dataFacturaDetail.Precio = factDetail.Precio;
                        dataFacturaDetail.ProductoID = factDetail.ProductoID;
                        dataFacturaDetail.Cantidad = factDetail.Cantidad;
                        dataFacturaDetail.ClientePedido = factDetail.ClientePedido;
                        dataFacturaDetail.OrderDID = factDetail.OrderDID;
                        dataFacturaHeader.FacturaDetails.Add(dataFacturaDetail);
                    }
                }

                resultPrepare = true;
            }
            catch (Exception ex)
            {

                resultPrepare = false;
            }

            return resultPrepare;
        }

        private void dgvFacturaDetail_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.OrdenID != null && this.OrdenID != string.Empty)
            {
                int colIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string ColumnEdit = dgvFacturaDetail.Columns[colIndex].HeaderText;

                switch (ColumnEdit.ToUpper())
                {
                    case "CANTIDAD":
                        IDOrdenDetail = dgvFacturaDetail.Rows[rowIndex].Cells["ColOrderDID"].Value.ToString();
                        break;
                    default:
                        break;
                }
            }

        }

        private void dgvFacturaDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.OrdenID != null && this.OrdenID != string.Empty)
            {
                decimal cantModif = 0;
                
                int colIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                string ColumnEdit = dgvFacturaDetail.Columns[colIndex].HeaderText;

                if (ColumnEdit.ToUpper() == "CANTIDAD")
                {
                    decimal.TryParse(dgvFacturaDetail.Rows[rowIndex].Cells["ColCant"].Value.ToString(), out cantModif);
                    viewDetalleGrid orderDetailModif = listOrdenDetailORG.FirstOrDefault(x => x.ID == IDOrdenDetail);
                    if (this.OrdenID == null || this.OrdenID == string.Empty)
                    {
                        dgvFacturaDetail.Rows[e.RowIndex].Cells["ColCant"].Value = orderDetailModif.Cantidad;
                        cantModif = orderDetailModif.Cantidad;
                    }
                    else
                    {
                        if (cantModif > orderDetailModif.Cantidad)
                        {
                            dgvFacturaDetail.Rows[e.RowIndex].Cells["ColCant"].Value = orderDetailModif.Cantidad;
                            cantModif = orderDetailModif.Cantidad;
                        }
                    }
                    dgvFacturaDetail.Rows[e.RowIndex].Cells["ColTotal"].Value = orderDetailModif.Precio * cantModif;
                    setFacturaDetail();
                }
            }
        }

        private void dgvFacturaDetail_Validating(object sender, CancelEventArgs e)
        {
            /*
            int dgvRowSelect = dgvFacturaDetail.SelectedCells[0].RowIndex;
            string cantidadProducto = dgvFacturaDetail.Rows[dgvRowSelect].Cells["ColCant"].Value.ToString();
            MessageBox.Show(cantidadProducto);
           */
        }
    }
}
