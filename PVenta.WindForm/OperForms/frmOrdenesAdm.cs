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
        private CallApies<viewOrderHeader, ApiOrderHeader> callApiOrdenes = new CallApies<viewOrderHeader, ApiOrderHeader>();
        private List<viewOrderHeader> listOrdenes;

        public frmOrdenesAdm()
        {
            InitializeComponent();
        }

        private void frmOrdenesAdm_Load(object sender, EventArgs e)
        {

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
            setDataSourceMesaGrid();
        }

        private void setDataSourceMesaGrid()
        {
            if (listOrdenes != null)
            {
                var listMesas = (from lmes in listOrdenes
                                 select new { Mesa = lmes.Mesa.Descripcion + " - "+ lmes.ClientePrincipal , lmes.ID }).ToList();
                dgvMesas.DataSource = listMesas;
            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idOrdenSelected = dgvMesas.Rows[e.RowIndex].Cells["ColID"].Value.ToString();

            cargaListOrden(idOrdenSelected);
        }

        private void cargaListOrden(string idOrdenSelected)
        {
            if (listOrdenes != null)
            {
                viewOrderHeader orderSel = listOrdenes.Where(x => x.ID == idOrdenSelected).FirstOrDefault();
                List<viewOrderDetail> orderDetailSel = orderSel.OrderDetails.ToList();
                

                var listOrden = (from lDeta in orderDetailSel
                                 select new { Producto = lDeta.producto.Nombre,
                                              lDeta.producto.Referencia,
                                              lDeta.Cantidad, lDeta.Precio,
                                              Total = lDeta.Cantidad* lDeta.Precio}).ToList();

                dgvOrderDetail.DataSource = listOrden;
                
            }
        }
    }
}
