using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
using PVenta.Utility;
using PVenta.WindForm.ApiCall;
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
    public partial class frmUsuariosAdm : Form
    {
        private CallApies<viewUsuario, ApiUsuario> callApiUsuario = new CallApies<viewUsuario, ApiUsuario>();
        private List<viewUsuario> listUsuarios;

        public frmUsuariosAdm()
        {
            InitializeComponent();
        }

        private void frmUsuariosAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L");
            cargaListaGRL();
        }

        private void cargaListaGRL()
        {
            callApiUsuario.urlApi = "api/Usuario/GetUsuarios/";
            callApiUsuario.CallGetList();
            listUsuarios = callApiUsuario.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listUsuarios != null)
            {
                this.dgvUsuarios.DataSource = listUsuarios;
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
            if (callApiUsuario.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiUsuario.listaResponse
                              where l.UserId.Contains(filtroText) ||
                              l.Nombre.Contains(filtroText) ||
                              l.Email.Contains(filtroText) ||
                              l.Rol.Nombre.Contains(filtroText)
                              select l).ToList();

                listUsuarios = result;
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUsuarioSelected = dgvUsuarios.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string nombreUsuario = dgvUsuarios.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();
            

            string columnClick = dgvUsuarios.Columns[e.ColumnIndex].HeaderText.ToString();


                switch (columnClick.ToUpper())
                {
                    case "EDITAR":
                        callUsuarioEditar(idUsuarioSelected);
                        break;
                    case "ELIMINAR":
                        callUsuarioEliminar(idUsuarioSelected);
                        break;
                    default:
                        //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                        break;
                }

            

        }

        private void callUsuarioEliminar(string idUsuarioSelected)
        {
            bool isValidated = Validations.validarID(idUsuarioSelected, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    ApiUsuario usuario = new ApiUsuario();
                    CallApies<viewMessageApp, ApiUsuario> MngApiRol = new CallApies<viewMessageApp, ApiUsuario>();
                    viewMessageApp result = null;

                    MngApiRol.urlApi = "api/Usuario/DeleteUsuario/" + idUsuarioSelected;
                    MngApiRol.objectRequest = usuario;
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

        private void callUsuarioEditar(string idUsuarioSelected)
        {
            bool isValidated = Validations.validarID(idUsuarioSelected, "Error en el parametro enviado...");

            if (isValidated)
            {
                frmUsuarios fUsuarios = new frmUsuarios();
                fUsuarios.modo = Modo.Editar;
                fUsuarios.UsuarioID = idUsuarioSelected;
                fUsuarios.setData();
                fUsuarios.ShowDialog();
                fUsuarios.Dispose();

                cargaListaGRL();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuarios fUsuarios = new frmUsuarios();
            fUsuarios.modo = Modo.Agregar;
            fUsuarios.setData();
            fUsuarios.ShowDialog();
            fUsuarios.Dispose();

            cargaListaGRL();
        }
    }
}
