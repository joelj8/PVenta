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
    public partial class frmMesasAdm : FormGRLA
    {

        private CallApies<viewMesa, ApiMesa> callApiMesa = new CallApies<viewMesa, ApiMesa>();
        private List<viewMesa> listMesas;

        public frmMesasAdm()
        {
            InitializeComponent();
        }

        private void frmMesasAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L");
            cargaListaGRL();
        }

        private void cargaListaGRL()
        {
            callApiMesa.urlApi = CollectAPI.GetMesas;
            callApiMesa.CallGetList();
            listMesas = callApiMesa.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listMesas != null)
            {
                this.dgvMesas.DataSource = listMesas;
            }
        }

        private void textFiltroMng(string modo)
        {
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString();
            string filtroText = txtFiltro.Text;
            if (callApiMesa.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiMesa.listaResponse
                              where l.Descripcion.Contains(filtroText) ||
                                    l.Orden.ToString().Contains(filtroText)
                              select l).ToList();

                listMesas = result;
                setDataSourceGrid();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMesas fMesas = new frmMesas();
            fMesas.modo = Modo.Agregar;
            fMesas.ShowDialog();
            fMesas.Dispose();
            cargaListaGRL();
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmesaselected = dgvMesas.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string columnClick = dgvMesas.Columns[e.ColumnIndex].HeaderText.ToString();

            switch (columnClick.ToUpper())
            {
                case "EDITAR":
                    callRolEditar(idmesaselected);
                    break;
                case "ELIMINAR":
                    callRolEliminar(idmesaselected);
                    break;
                default:
                    //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                    break;
            }

        }

        private void callRolEliminar(string idmesaselected)
        {
            bool isValidated = Validations.validarID(idmesaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    CallApies<viewMessageApp, ApiMesa> MngApiRol = new CallApies<viewMessageApp, ApiMesa>();
                    viewMessageApp result = null;

                    MngApiRol.urlApi = CollectAPI.DeleteMesa + idmesaselected;
                    MngApiRol.CallPost();
                    result = MngApiRol.objectResponse;
                    if (result != null)
                    {
                        cargaListaGRL();
                        MessageBox.Show(result.Evento, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void callRolEditar(string idmesaselected)
        {
            bool isValidated = Validations.validarID(idmesaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                frmMesas fMesas = new frmMesas();
                fMesas.modo = Modo.Editar;
                fMesas.MesaID = idmesaselected;
                fMesas.setData();
                fMesas.ShowDialog();
                fMesas.Dispose();
                cargaListaGRL();
            }
        }
    }
}
