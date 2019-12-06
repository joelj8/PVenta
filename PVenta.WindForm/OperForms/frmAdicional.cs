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
    public partial class frmAdicional : FormGRLA
    {
        public TipoForm TipoForm { get; set; }

        private CallApies<viewProducto, ApiProducto> callApiProducto = new CallApies<viewProducto, ApiProducto>();
        private List<viewAdicionalDetailGrid> gridAdicionales = new List<viewAdicionalDetailGrid>();
        public List<viewOrderDetailGrid> gridOrderDetailMng = null;
        
        public decimal numOrden = 0;
        public frmAdicional()
        {
            InitializeComponent();
        }

        private void frmAdicional_Load(object sender, EventArgs e)
        {
            dgvAdicionales.ColumnHeadersDefaultCellStyle.Font = GeneralFormsSettings.FontHeaderGrid;
        }

        public void setDataBusqueda()
        {
            callApiProducto.urlApi = CollectAPI.GetProductos;
            callApiProducto.CallGetList();
        }

        private void txtReferencia_Validated(object sender, EventArgs e)
        {
            findProduct();
        }

        private void findProduct()
        {
            string findProductRef = txtReferencia.Text.Trim().ToLower();
            if (findProductRef != string.Empty)
            {
                clearInfoProduct();
                if (callApiProducto.listaResponse == null)
                {
                    setDataBusqueda();
                }
                    viewProducto ProductSelect = (from lprod in callApiProducto.listaResponse
                                                  where lprod.Referencia.Trim().ToLower().Equals(findProductRef)
                                                        && lprod.esAdicional
                                                  orderby lprod.Referencia
                                                  select lprod).FirstOrDefault();

                    setProductoInfo(ProductSelect);
                
            }
        }

        private void setProductoInfo(viewProducto productSelect)
        {
            if (productSelect != null)
            {
                txtProducto.Text = productSelect.Nombre;
                numCantidad.Value = 1;
                numPrecio.Value = productSelect.Precio;
                txtID.Text = productSelect.ID;

                calcTotalProductoInfo();
                numCantidad.Focus();
            }
        }

        private void calcTotalProductoInfo()
        {
            numTotal.Value = (numCantidad.Value * numPrecio.Value);
        }

        private void clearInfoProduct(bool hardClear = false)
        {
            if (hardClear)
            {
                txtReferencia.Text = string.Empty;
            }
            txtProducto.Text = string.Empty;
            numCantidad.Value = decimal.Zero;
            numPrecio.Value = decimal.Zero;
            numTotal.Value = decimal.Zero;
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcTotalProductoInfo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            callApiProducto.urlApi = CollectAPI.GetProducto;
            callApiProducto.CallGet(txtID.Text);
            if (callApiProducto.objectResponse != null)
            {
                viewAdicionalDetailGrid newAdicionalDetail = new viewAdicionalDetailGrid();

                newAdicionalDetail.ID = Guid.NewGuid().ToString();
                newAdicionalDetail.ProductoID = txtID.Text;

                newAdicionalDetail.Orden = nextOrdenNo(gridAdicionales);

                newAdicionalDetail.Cantidad = numCantidad.Value;
                newAdicionalDetail.Precio = numPrecio.Value;
                newAdicionalDetail.Referencia = callApiProducto.objectResponse.Referencia;
                newAdicionalDetail.ImpComanda = (callApiProducto.objectResponse.ImpComanda ?
                                            callApiProducto.objectResponse.ImpComanda :
                                          callApiProducto.objectResponse.Categoria.ImpComanda);
                newAdicionalDetail.producto = callApiProducto.objectResponse.Nombre;

                gridAdicionales.Add(newAdicionalDetail);
                setOrderDetail();
                clearInfoProduct(true);
                txtReferencia.Focus();
            }
        }

        private void setOrderDetail()
        {
            if (gridAdicionales != null)
            {
                var listGrid = gridAdicionales.OrderByDescending(s => s.Orden).ToList();
                this.dgvAdicionales.DataSource = listGrid;
            }

        }

        private decimal nextOrdenNo(List<viewAdicionalDetailGrid> AdicionalesDetail)
        {
            decimal resultado = 0;

            if (AdicionalesDetail != null && AdicionalesDetail.Count > 0)
            {
                resultado = (from ordDetaAdicc in AdicionalesDetail
                             where (int)ordDetaAdicc.Orden - ordDetaAdicc.Orden != 0
                             select (ordDetaAdicc.Orden - (int)ordDetaAdicc.Orden)*100).Max();
            }
            resultado += 1;
            resultado = numOrden + (resultado / 100);
            return resultado;
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                findProduct();
            }
        }

        private void numCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregar.Focus();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool result = false;
            switch (this.TipoForm)
            {
                case TipoForm.Orden:
                    result = registrarDetalleOrden();
                    break;
                case TipoForm.Factura:
                    break;
            }

            if (result)
            {
                this.Close();
            }
        }

        private bool registrarDetalleOrden()
        {
            bool result = false;
            bool found = false;

            try
            {
                foreach (viewAdicionalDetailGrid Data in gridAdicionales)
                {
                    bool regExiste = gridOrderDetailMng.Count(x => x.ID == Data.ID) > 0;

                    if (!regExiste)
                    {
                        registrarNewDetOrden(Data);
                    }
                }

                List<viewOrderDetailGrid> gridExcluir = new List<viewOrderDetailGrid>();

                foreach (viewOrderDetailGrid DataGrid in gridOrderDetailMng)
                {

                    if (DataGrid.Orden - decimal.Truncate(DataGrid.Orden)  > 0)
                    {
                        found = false;
                        foreach (viewAdicionalDetailGrid Data in gridAdicionales)
                        {
                            if (DataGrid.ID == Data.ID)
                            {
                                found = true;
                            }
                        }

                        // Solo debe excluir a los hijos del producto padre
                        if (!found)
                        {
                            viewOrderDetailGrid dataAdd = DataGrid; //DataGrid.Clone() as viewOrderDetailGrid;
                            gridExcluir.Add(dataAdd);
                        }
                    }
                }

                foreach (viewOrderDetailGrid DataDel in gridExcluir)
                {
                    gridOrderDetailMng.Remove(DataDel);
                }

                result = true;
            }
            catch (Exception ex)
            {
                //Registr
                result = false;
            }

            return result;
        }

        private void registrarNewDetOrden(viewAdicionalDetailGrid Data)
        {

                viewOrderDetailGrid ordDetailNew = new viewOrderDetailGrid();
                ordDetailNew.ID = Data.ID;
                ordDetailNew.ImpComanda = Data.ImpComanda;
                ordDetailNew.Impreso = Data.Impreso;
                ordDetailNew.Orden = Data.Orden;
                ordDetailNew.Cantidad = Data.Cantidad;
                ordDetailNew.Precio = Data.Precio;
                ordDetailNew.ProductoID = Data.ProductoID;
                ordDetailNew.Referencia = Data.Referencia;
                ordDetailNew.producto =  "      "+Data.producto;
                gridOrderDetailMng.Add(ordDetailNew);
        }

        public void setDataAdicional()
        {
            List<viewOrderDetailGrid> regAdicionales = (from addDetail in gridOrderDetailMng
                                                      where (int)addDetail.Orden == (int)this.numOrden &&
                                                            (int)addDetail.Orden - addDetail.Orden != 0
                                                      select addDetail).ToList();

            foreach(viewOrderDetailGrid regPrev in regAdicionales)
            {
                viewAdicionalDetailGrid adicionalesReg = new viewAdicionalDetailGrid();

                adicionalesReg.Cantidad = regPrev.Cantidad;
                adicionalesReg.ID = regPrev.ID;
                adicionalesReg.ImpComanda = regPrev.ImpComanda;
                adicionalesReg.Impreso = regPrev.Impreso;
                adicionalesReg.Orden = regPrev.Orden;
                adicionalesReg.Precio = regPrev.Precio;
                adicionalesReg.producto = regPrev.producto.Trim();
                adicionalesReg.ProductoID = regPrev.ProductoID;
                adicionalesReg.Referencia = regPrev.Referencia;

                gridAdicionales.Add(adicionalesReg);
            }

            setOrderDetail();
        }

        private void dgvAdicionales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                int CountSelect = dgvAdicionales.GetCellCount(DataGridViewElementStates.Selected);
                if (CountSelect > 0)
                {
                    int dgvRowSelect = dgvAdicionales.SelectedCells[0].RowIndex;
                    string idOrderGrid = dgvAdicionales.Rows[dgvRowSelect].Cells["ColID"].Value.ToString();

                    string nombreProducto = dgvAdicionales.Rows[dgvRowSelect].Cells["ColProducto"].Value.ToString();
                    string cantidadProducto = dgvAdicionales.Rows[dgvRowSelect].Cells["ColCant"].Value.ToString();
                    bool infoImpreso = (bool)dgvAdicionales.Rows[dgvRowSelect].Cells["ColImpreso"].Value;

                    if (!infoImpreso)
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
                viewAdicionalDetailGrid ordDetElimina = (from gODElim in gridAdicionales
                                                     where gODElim.ID == idOrderGrid
                                                     select gODElim).FirstOrDefault();

                if (ordDetElimina != null)
                {
                    gridAdicionales.Remove(ordDetElimina);

                    setOrderDetail();
                }
            }
        }
    }
}
