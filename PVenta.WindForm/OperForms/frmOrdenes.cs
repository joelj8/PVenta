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
    public partial class frmOrdenes : FormGRLA
    {
        public viewLogin userApp = null;
        public Modo modo { get; set; }
        public string OrderID { get; set; }
        private CallApies<viewUsuario, ApiUsuario> callApiUsuario = new CallApies<viewUsuario, ApiUsuario>();
        private CallApies<viewMesa, ApiMesa> callApiMesa = new CallApies<viewMesa, ApiMesa>();
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
        }

    }
}
