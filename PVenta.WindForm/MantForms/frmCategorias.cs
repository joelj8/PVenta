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
    public partial class frmCategorias : FormGRLA
    {
        internal Modo modo;

        public string CategoriaID { get; set; }
        private viewMessageApp result = null;
        private ApiCategoria categoria = new ApiCategoria();

        private CallApies<viewCategoria, ApiCategoria> callApiCategoria = new CallApies<viewCategoria, ApiCategoria>();
        private CallApies<viewMessageApp, ApiCategoria> MngApiCategoria = new CallApies<viewMessageApp, ApiCategoria>();


        public frmCategorias()
        {
            InitializeComponent();
        }

        

        private void frmCategorias_Load(object sender, EventArgs e)
        {

        }

        internal void setData()
        {
            if (CategoriaID != string.Empty)
            {
                callApiCategoria.urlApi = CollectAPI.GetCategoria;
                callApiCategoria.CallGet(CategoriaID);
                if (callApiCategoria.objectResponse != null)
                {
                    txtDescripcion.Text = callApiCategoria.objectResponse.Descripcion;
                    chkImpComanda.Checked = callApiCategoria.objectResponse.ImpComanda;
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertCategoria);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateCategoria);
                    break;
            }

            msgResult();
        }

        private void msgResult()
        {
            if (result != null)
            {
                MessageBoxIcon msgIcon = result.esError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
                MessageBox.Show(result.Evento, this.Text.ToString(), MessageBoxButtons.OK, msgIcon);
                if (!result.esError)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error no controlado...", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveData(string urlApi)
        {
            prepareData();
            MngApiCategoria.urlApi = urlApi;
            MngApiCategoria.objectRequest = categoria;
            MngApiCategoria.CallPost();
            result = MngApiCategoria.objectResponse;
        }

        private void prepareData()
        {
            if (modo == Modo.Editar)
            {
                categoria.ID = CategoriaID;
            }
            categoria.Descripcion = txtDescripcion.Text;
            categoria.ImpComanda = chkImpComanda.Checked;
        }
    }
}
