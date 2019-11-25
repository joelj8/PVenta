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
    public partial class frmProductos : FormGRLA
    {
        internal Modo modo;

        public string ProductoID { get; internal set; }

        private viewMessageApp result = null;
        private ApiProducto producto = new ApiProducto();

        private CallApies<viewProducto, ApiProducto> callApiProducto = new CallApies<viewProducto, ApiProducto>();
        private CallApies<viewCategoria, ApiCategoria> callApiCategoria = new CallApies<viewCategoria, ApiCategoria>();
        private CallApies<viewMessageApp, ApiProducto> MngApiProducto = new CallApies<viewMessageApp, ApiProducto>();

        public frmProductos()
        {
            InitializeComponent();
        }
        public void setData()
        {
            setDataCombo();

            if (ProductoID != string.Empty)
            {
                callApiProducto.urlApi = CollectAPI.GetProducto;
                callApiProducto.CallGet(ProductoID);
                if (callApiProducto.objectResponse != null)
                {
                    txtNombre.Text = callApiProducto.objectResponse.Nombre;
                    txtNombreCorto.Text = callApiProducto.objectResponse.NombreCorto;
                    txtReferencia.Text = callApiProducto.objectResponse.Referencia;
                    numPrecio.Value = callApiProducto.objectResponse.Precio;
                    cboCategoria.SelectedValue = callApiProducto.objectResponse.Categoria.ID;
                    chkAdicional.Checked = callApiProducto.objectResponse.esAdicional;
                    chkComanda.Checked = callApiProducto.objectResponse.ImpComanda;


                }


            }
        }

        public void setDataCombo()
        {

            callApiCategoria.urlApi = CollectAPI.GetCategorias;
            callApiCategoria.CallGetList();
            if (callApiCategoria.listaResponse != null)
            {
                BindingSource bdS = new BindingSource();
                bdS.DataSource = callApiCategoria.listaResponse;
                cboCategoria.DataSource = bdS.DataSource;
                
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "ID";
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool validado = validarData();
            if (validado)
            {
                switch (this.modo)
                {
                    case Modo.Agregar:
                        saveData(CollectAPI.InsertProducto);
                        break;
                    case Modo.Editar:
                        saveData(CollectAPI.UpdateProducto);
                        break;
                }

                msgResult();

            }
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

            MngApiProducto.urlApi = urlApi;
            MngApiProducto.objectRequest = producto;
            MngApiProducto.CallPost();
            result = MngApiProducto.objectResponse;
        }

        private void prepareData()
        {

            if (modo == Modo.Editar)
            {
                producto.ID = ProductoID;
            }

            producto.Nombre = txtNombre.Text;
            producto.NombreCorto = txtNombreCorto.Text;
            producto.Referencia = txtReferencia.Text;
            producto.CategoriaId = cboCategoria.SelectedValue.ToString();
            producto.Precio = numPrecio.Value;
            producto.esAdicional = chkAdicional.Checked;
            producto.ImpComanda = chkComanda.Checked;
            
        }

        private bool validarData()
        {
            bool validaResult = true;

            // Validando el Nombre
            if (txtNombre.Text == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar el Nombre del Producto...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando el Nombre
            if (txtReferencia.Text == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar la Referencia del Producto...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando la categoria
            if (cboCategoria.SelectedValue.ToString() == string.Empty && validaResult)
            {
                validaResult = false;
                MessageBox.Show("Error, Debe indicar la Categoria del Producto...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validando el UserId
            string textReferencia = txtReferencia.Text;
            string textNombre = txtNombre.Text;
            callApiProducto.urlApi = CollectAPI.GetProductos;
            callApiProducto.CallGetList();
            int cantUserExist = (from dt in callApiProducto.listaResponse
                                 where dt.ID != ProductoID &&
                                       (dt.Nombre.ToLower() == textNombre.ToLower() ||
                                        dt.Referencia.ToLower() == textReferencia.ToLower())
                                 select dt).Count();
            if (cantUserExist > 0 && validaResult)
            {
                validaResult = false;
                MessageBox.Show(string.Format("Error, El Producto '{0}' y/o Referencia '{1}' fue registrado previamente...", textNombre, textReferencia), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return validaResult;
        }
    }
}
