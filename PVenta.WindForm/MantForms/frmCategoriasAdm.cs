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
    public partial class frmCategoriasAdm : FormGRLA
    {
        private CallApies<viewCategoria, ApiCategoria> callApiCategoria = new CallApies<viewCategoria, ApiCategoria>();
        private List<viewCategoria> listCategorias;

        public frmCategoriasAdm()
        {
            InitializeComponent();
        }

        private void frmCategoriasAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L", true);
            cargaListaGRL();
        }

        private void cargaListaGRL()
        {
            callApiCategoria.urlApi = CollectAPI.GetCategorias;
            callApiCategoria.CallGetList();
            listCategorias = callApiCategoria.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listCategorias != null)
            {
                this.dgvCategorias.DataSource = listCategorias;
            }
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString().ToLower();
            string filtroText = txtFiltro.Text.ToLower();
            if (callApiCategoria.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiCategoria.listaResponse
                              where l.Descripcion.ToLower().Contains(filtroText) 
                              select l).ToList();

                listCategorias = result;
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
            frmCategorias fCategorias = new frmCategorias();
            fCategorias.modo = Modo.Agregar;
            fCategorias.ShowDialog();
            fCategorias.Dispose();
            textFiltroMng("L", true);
            cargaListaGRL();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcategoriaselected = dgvCategorias.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string columnClick = dgvCategorias.Columns[e.ColumnIndex].HeaderText.ToString();

            switch (columnClick.ToUpper())
            {
                case "EDITAR":
                    callEditar(idcategoriaselected);
                    break;
                case "ELIMINAR":
                    callEliminar(idcategoriaselected);
                    break;
                default:
                    //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                    break;
            }
        }

        private void callEliminar(string idcategoriaselected)
        {
            bool isValidated = Validations.validarID(idcategoriaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    CallApies<viewMessageApp, ApiCategoria> MngApiMoneda = new CallApies<viewMessageApp, ApiCategoria>();
                    viewMessageApp result = null;

                    MngApiMoneda.urlApi = CollectAPI.DeleteCategoria + idcategoriaselected;
                    MngApiMoneda.CallPost();
                    result = MngApiMoneda.objectResponse;
                    if (result != null)
                    {
                        textFiltroMng("L", true);
                        cargaListaGRL();
                        MessageBox.Show(result.Evento, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void callEditar(string idcategoriaselected)
        {
            
            bool isValidated = Validations.validarID(idcategoriaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                frmCategorias fCategorias = new frmCategorias();
                fCategorias.modo = Modo.Editar;
                fCategorias.CategoriaID = idcategoriaselected;
                fCategorias.setData();
                fCategorias.ShowDialog();
                fCategorias.Dispose();
                textFiltroMng("L", true);
                cargaListaGRL();
            }
        }
    }
}
