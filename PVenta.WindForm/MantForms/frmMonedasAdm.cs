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
    public partial class frmMonedasAdm : FormGRLA
    {
        private CallApies<viewMoneda, ApiMesa> callApiMoneda = new CallApies<viewMoneda, ApiMesa>();
        private List<viewMoneda> listMonedas;

        public frmMonedasAdm()
        {
            InitializeComponent();
        }

        private void frmMonedasAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L",true);
            cargaListaGRL();

        }

        private void cargaListaGRL()
        {
            callApiMoneda.urlApi = CollectAPI.GetMonedas;
            callApiMoneda.CallGetList();
            listMonedas = callApiMoneda.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listMonedas != null)
            {
                this.dgvMonedas.DataSource = listMonedas;
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
            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString();
            string filtroText = txtFiltro.Text;
            if (callApiMoneda.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiMoneda.listaResponse
                              orderby l.Valor
                              where l.Descripcion.Contains(filtroText) ||
                                    l.Valor.ToString().Contains(filtroText)
                              select l).ToList();

                listMonedas = result;
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
            frmMonedas fMonedas = new frmMonedas();
            fMonedas.modo = Modo.Agregar;
            fMonedas.ShowDialog();
            fMonedas.Dispose();
            textFiltroMng("L",true);
            cargaListaGRL();
        }

        private void dgvMonedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmonedaselected = dgvMonedas.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string columnClick = dgvMonedas.Columns[e.ColumnIndex].HeaderText.ToString();

            switch (columnClick.ToUpper())
            {
                case "EDITAR":
                    callEditar(idmonedaselected);
                    break;
                case "ELIMINAR":
                    callEliminar(idmonedaselected);
                    break;
                default:
                    //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                    break;
            }
        }

        private void callEliminar(string idmonedaselected)
        {
            bool isValidated = Validations.validarID(idmonedaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    CallApies<viewMessageApp, ApiMesa> MngApiMoneda = new CallApies<viewMessageApp, ApiMesa>();
                    viewMessageApp result = null;

                    MngApiMoneda.urlApi = CollectAPI.DeleteMoneda + idmonedaselected;
                    MngApiMoneda.CallPost();
                    result = MngApiMoneda.objectResponse;
                    if (result != null)
                    {
                        textFiltroMng("L",true);
                        cargaListaGRL();
                        MessageBox.Show(result.Evento, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void callEditar(string idmonedaselected)
        {
            bool isValidated = Validations.validarID(idmonedaselected, "Error en el parametro enviado...");
            if (isValidated)
            {
                frmMonedas fMonedas = new frmMonedas();
                fMonedas.modo = Modo.Editar;
                fMonedas.MonedaID = idmonedaselected;
                fMonedas.setData();
                fMonedas.ShowDialog();
                fMonedas.Dispose();
                textFiltroMng("L",true);
                cargaListaGRL();
            }
        }
    }


}
