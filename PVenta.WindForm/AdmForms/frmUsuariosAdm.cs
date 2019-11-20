using PVenta.Models.ApiModels;
using PVenta.Models.ViewModel;
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
    }
}
