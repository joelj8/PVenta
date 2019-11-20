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
    public partial class frmRolesAdm : Form
    {
        private  CallApies<viewRol, ApiRol> callApiRol = new CallApies<viewRol, ApiRol>();
        private List<viewRol> listRoles;
        public frmRolesAdm()
        {
            InitializeComponent();
        }

        private void frmRolesAdm_Load(object sender, EventArgs e)
        {
            textFiltroMng("L");
            cargaListaGRL();

            //setupDataGridViewRoles();
            //setupDataGridViewRol();
        }

        private void cargaListaGRL()
        {
            callApiRol.urlApi = "api/Rol/GetRoles/";
            callApiRol.CallGetList();
            listRoles = callApiRol.listaResponse.ToList();
            setDataSourceGrid();
        }

        private void setDataSourceGrid()
        {
            if (listRoles != null)
            {
                this.dgvRoles.DataSource = listRoles;
            }
            
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string idrolseleted = dgvRoles.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
            string nombreRol = dgvRoles.Rows[e.RowIndex].Cells["ColNombre"].Value.ToString();
            bool esModificable = (bool)dgvRoles.Rows[e.RowIndex].Cells["ColModificable"].Value;

            string columnClick = dgvRoles.Columns[e.ColumnIndex].HeaderText.ToString();

           // MessageBox.Show(string.Format("{1} el ID: {0}",idrolseleted, columnClick));

           if (esModificable)
            {
                switch (columnClick.ToUpper())
                {
                    case "EDITAR":
                        callRolEditar(idrolseleted);
                        break;
                    case "ELIMINAR":
                        callRolEliminar(idrolseleted);
                        break;
                    default:
                        //MessageBox.Show(string.Format("El parametro {0} no es valido...", columnClick), "Administración Rol");
                        break;
                }

            } else
            {
                MessageBox.Show(string.Format("El rol {0} no se puede {1}...",nombreRol, columnClick.ToLower()), "Administración Rol");
            }

            

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string textFiltroDefault = Properties.Settings.Default.TextoFiltro.ToString();
            string filtroText = txtFiltro.Text;
            if (callApiRol.listaResponse != null && textFiltroDefault != filtroText)
            {
                var result = (from l in callApiRol.listaResponse
                              where l.Nombre.Contains(filtroText)
                              select l).ToList();

                listRoles = result;
                setDataSourceGrid();
            }
            
        }

        private void txtFiltro_Leave(object sender, EventArgs e)
        {
            textFiltroMng("L");
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

        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            textFiltroMng("E");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRoles fRoles = new frmRoles();
            fRoles.modo = Modo.Agregar;
            fRoles.ShowDialog();
            fRoles.Dispose();
            cargaListaGRL();
        }

        private void callRolEditar(string idrolseleted)
        {
            bool isValidated = Validations.validarID(idrolseleted, "Error en el parametro enviado...");

            if (isValidated)
            {
                frmRoles fRoles = new frmRoles();
                fRoles.modo = Modo.Editar;
                fRoles.RolID = idrolseleted;
                fRoles.setData();
                fRoles.ShowDialog();
                fRoles.Dispose();
                cargaListaGRL();
            }
            
        }

        private void callRolEliminar(string idrolseleted)
        {
            bool isValidated = Validations.validarID(idrolseleted, "Error en el parametro enviado...");
            if (isValidated)
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar este registro?", this.Text, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    ApiRol rol = new ApiRol();
                    CallApies<viewMessageApp, ApiRol> MngApiRol = new CallApies<viewMessageApp, ApiRol>();
                    viewMessageApp result = null;

                    MngApiRol.urlApi = "api/Rol/DeleteRol/" + idrolseleted;
                    MngApiRol.objectRequest = rol;
                    MngApiRol.CallPost();
                    result = MngApiRol.objectResponse;
                    if (result != null)
                    {
                        cargaListaGRL();
                        MessageBox.Show(result.Evento, this.Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
