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

namespace PVenta.WindForm.AdmForms
{
    public partial class frmTypeInformacionesAdm : FormGRLA
    {
        private CallApies<viewTypeInformacion, ApiTypeInformacion> callApiTypeInformacion = new CallApies<viewTypeInformacion, ApiTypeInformacion>();
        private List<viewTypeInformacion> listTypeInformaciones;
        public frmTypeInformacionesAdm()
        {
            InitializeComponent();
        }

        private void frmTypeInformacionesAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L");
            cargaListaGRL();
        }

        private void cargaListaGRL()
        {
            callApiTypeInformacion.urlApi = CollectAPI.GetTypeInformaciones;
            callApiTypeInformacion.CallGetList();
            listTypeInformaciones = callApiTypeInformacion.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listTypeInformaciones != null)
            {
                this.dgvTypeInformaciones.DataSource = listTypeInformaciones;
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

        private void dgvTypeInformaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idrolseleted = dgvTypeInformaciones.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string columnClick = dgvTypeInformaciones.Columns[e.ColumnIndex].HeaderText.ToString();

            switch (columnClick.ToUpper())
            {
                case "EDITAR":
                    callTypeInformacionEditar(idrolseleted);
                    break;
                case "ELIMINAR":
                    callTypeInformacionEliminar(idrolseleted);
                    break;
                default:
                    //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                    break;
            }
        
        }

        private void callTypeInformacionEliminar(string idrolseleted)
        {
            bool isValidated = Validations.validarID(idrolseleted, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    CallApies<viewMessageApp, ApiTypeInformacion> MngApiRol = new CallApies<viewMessageApp, ApiTypeInformacion>();
                    viewMessageApp result = null;

                    MngApiRol.urlApi = CollectAPI.DeleteTypeInformacion + idrolseleted;
                    MngApiRol.CallPost();
                    result = MngApiRol.objectResponse;
                    if (result != null)
                    {
                        textFiltroMng("L", true);
                        cargaListaGRL();
                        MessageBox.Show(result.Evento, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void callTypeInformacionEditar(string idrolseleted)
        {
            bool isValidated = Validations.validarID(idrolseleted, "Error en el parametro enviado...");

            if (isValidated)
            {
                frmTypeInformacion fTypeInformacion = new frmTypeInformacion();
                fTypeInformacion.modo = Modo.Editar;
                fTypeInformacion.TypeInformacionID = idrolseleted;
                fTypeInformacion.setData();
                fTypeInformacion.ShowDialog();
                fTypeInformacion.Dispose();
                textFiltroMng("L", true);
                cargaListaGRL();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTypeInformacion fTypeInformacion = new frmTypeInformacion();
            fTypeInformacion.modo = Modo.Agregar;
            fTypeInformacion.ShowDialog();
            fTypeInformacion.Dispose();
            textFiltroMng("L", true);
            cargaListaGRL();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString().ToLower();
            string filtroText = txtFiltro.Text.ToLower();
            if (callApiTypeInformacion.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiTypeInformacion.listaResponse
                              where l.Descripcion.ToLower().Contains(filtroText)
                              select l).ToList();

                listTypeInformaciones = result;
                setDataSourceGrid();
            }
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            textFiltroMng("L");
        }

        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            textFiltroMng("E");
        }
    }
}
