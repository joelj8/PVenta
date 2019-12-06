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
    public partial class frmOrdenes : FormGRLA
    {
        public viewLogin userApp = null;
        public Modo modo { get; set; }
        public string OrderID { get; set; }
        
        private CallApies<viewUsuario, ApiUsuario> callApiUsuario = new CallApies<viewUsuario, ApiUsuario>();
        private CallApies<viewMesa, ApiMesa> callApiMesa = new CallApies<viewMesa, ApiMesa>();
        private CallApies<viewProducto, ApiProducto> callApiProducto = new CallApies<viewProducto, ApiProducto>();
        private List<viewOrderDetailGrid> gridOrderDetail = new List<viewOrderDetailGrid>();
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
            
        }

        public void InitNewOrder()
        {
            setDataCombo();
            txtFecha.Text = DateTime.Now.ToString();
            cboUsuario.SelectedValue = this.userApp.ID;
            chkITBIS.Checked = gConfigSistema.configSistemaInfo.CalcITBIS;
            chkServicio.Checked = gConfigSistema.configSistemaInfo.CalcServicio;
            //txtClientePrincipal.Text = gConfigSistema.configSistemaInfo.PorcITBIS.ToString();

        }

        public void setDataCombo()
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

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            findProductByReferencia();
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                findProductByReferencia();
            }
            
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
                viewOrderDetailGrid newOrdDetail = new viewOrderDetailGrid();
                
                newOrdDetail.ID = Guid.NewGuid().ToString();
                newOrdDetail.ProductoID = txtID.Text;
                newOrdDetail.ClientePedido = string.Empty;
                
                newOrdDetail.Orden = nextOrdenNo(gridOrderDetail);
                newOrdDetail.OrderHID = string.Empty;

                newOrdDetail.Cantidad = numCant.Value;
                newOrdDetail.Precio = numPrecio.Value;
                newOrdDetail.Referencia = callApiProducto.objectResponse.Referencia;
                newOrdDetail.ImpComanda = (callApiProducto.objectResponse.ImpComanda ?
                                            callApiProducto.objectResponse.ImpComanda :
                                          callApiProducto.objectResponse.Categoria.ImpComanda);
                newOrdDetail.producto = callApiProducto.objectResponse.Nombre;

                gridOrderDetail.Add(newOrdDetail);
                setOrderDetail();
                clearInfoProduct(true);
                txtReferencia.Focus();
            }
        }

        private decimal nextOrdenNo(List<viewOrderDetailGrid> OrderDetailEvalua)
        {
            decimal resultado = 0;
            if (OrderDetailEvalua != null && OrderDetailEvalua.Count > 0)
            {
                resultado = (from ordDeta in OrderDetailEvalua
                             where (int)ordDeta.Orden - ordDeta.Orden == 0
                             select ordDeta.Orden).Max();
            }
            
            
            resultado += 1;
            return resultado;
        }

        private void setOrderDetail()
        {
            if (gridOrderDetail != null)
            {
                var listGrid = gridOrderDetail.OrderBy(s => s.Orden).ToList();
                this.dgvOrderDetail.DataSource = listGrid;
            }
            calculateOrder();
        }

        private void calculateOrder()
        {
            /*
             decimal valDescuento = 0;
            decimal valITBIS = 0;
            decimal valTotal = 0;
            decimal valServicio = 0;*/

            decimal valPorcGRL = 0;
            decimal valSubTotal = gridOrderDetail.Sum(x => x.Total);

            decimal valDescuento = (numDescMonto.Value + (valSubTotal * (numDescPorc.Value / 100)));
            valPorcGRL = chkITBIS.Checked ? (gConfigSistema.configSistemaInfo.PorcITBIS / 100) : 0;
            decimal valITBIS = (valSubTotal - valDescuento) * valPorcGRL;
                valPorcGRL = chkServicio.Checked ? (gConfigSistema.configSistemaInfo.PorcServicio / 100) : 0;
            decimal valServicio = (valSubTotal - valDescuento) * valPorcGRL;
            decimal valTotal = valSubTotal - valDescuento + valITBIS +valServicio;
            
            txtSubTotal.Text = valSubTotal.ToString("c");
            txtDescuento.Text = valDescuento.ToString("c");
            txtITBIS.Text = valITBIS.ToString("c");
            txtServicio.Text = valServicio.ToString("c");
            txtTotal.Text = valTotal.ToString("c");

        }

        private void cargarOrderDetail()
        {

            setOrderDetail();

        }

        private void dgvOrderDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 8)
            {
                int dgvCountSelect = dgvOrderDetail.GetCellCount(DataGridViewElementStates.Selected);
                if (dgvCountSelect > 0)
                {
                    int dgvRowSelect = dgvOrderDetail.SelectedCells[0].RowIndex;
                    string idOrderGrid = dgvOrderDetail.Rows[dgvRowSelect].Cells["ColID"].Value.ToString();
                    string productoID = dgvOrderDetail.Rows[dgvRowSelect].Cells["ColProductoID"].Value.ToString();
                    string nombreProducto = dgvOrderDetail.Rows[dgvRowSelect].Cells["ColProducto"].Value.ToString();
                    string cantidadProducto = dgvOrderDetail.Rows[dgvRowSelect].Cells["ColCant"].Value.ToString();
                    bool infoImpreso = (bool)dgvOrderDetail.Rows[dgvRowSelect].Cells["ColImpreso"].Value;
                    viewProducto productoSelect = findProductByID(productoID);
                    if (!infoImpreso && !productoSelect.esAdicional)
                    {
                        DialogResult respuesta = MessageBox.Show(string.Format("Desea eliminar el producto {0} Cantidad {1}?", nombreProducto, cantidadProducto), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.Yes)
                        {
                            eliminaRecord(idOrderGrid);
                        }
                    }
                }
                
            }
        }

        private void eliminaRecord(string idOrderGrid)
        {
            if (idOrderGrid != null && idOrderGrid != string.Empty)
            {
                viewOrderDetailGrid ordDetElimina = (from gODElim in gridOrderDetail
                                                     where gODElim.ID == idOrderGrid
                                                     select gODElim).FirstOrDefault();

                if (ordDetElimina != null)
                {
                    gridOrderDetail.Remove(ordDetElimina);

                    decimal noOrdenRelacionado = decimal.Truncate(ordDetElimina.Orden);
                    List<viewOrderDetailGrid> ordDetaEliminaAdicionales = (from goElimAdic in gridOrderDetail
                                                                           where (int)goElimAdic.Orden == noOrdenRelacionado
                                                                           select goElimAdic).ToList();

                    foreach (viewOrderDetailGrid ordDetaElimAdicional in ordDetaEliminaAdicionales)
                    {
                        gridOrderDetail.Remove(ordDetaElimAdicional);
                    }


                    setOrderDetail();
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
            calculateOrder();
        }

        private void numDescPorc_Validated(object sender, EventArgs e)
        {
            calculateOrder();

        }

        private void numDescMonto_Validated(object sender, EventArgs e)
        {
            calculateOrder();

        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            calculateOrder();
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal numOrdenPadre = decimal.Parse(dgvOrderDetail.Rows[e.RowIndex].Cells["ColOrden"].Value.ToString());
            string idProducto = dgvOrderDetail.Rows[e.RowIndex].Cells["ColProductoID"].Value.ToString();
            string columnClick = dgvOrderDetail.Columns[e.ColumnIndex].HeaderText.ToString();

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
                fAdicional.TipoForm = TipoForm.Orden;
                fAdicional.numOrden = numOrdenPadre;
                fAdicional.gridOrderDetailMng = gridOrderDetail;
                fAdicional.setDataAdicional();
                fAdicional.ShowDialog();
                fAdicional.Dispose();
                setOrderDetail();
            }
            

        }

        private void callDividir()
        {
            throw new NotImplementedException();
        }
    }
}
