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
    public partial class frmTypeInformacion : FormGRLA
    {

        public string TypeInformacionID { get; set; }
        public Modo modo { get; set; }
        private viewMessageApp result = null;
        private ApiTypeInformacion typeInformacion = new ApiTypeInformacion();

        private CallApies<viewTypeInformacion, ApiTypeInformacion> callApiTypeInformacion = new CallApies<viewTypeInformacion, ApiTypeInformacion>();
        private CallApies<viewMessageApp, ApiTypeInformacion> MngApiTypeInformacion = new CallApies<viewMessageApp, ApiTypeInformacion>();

        public frmTypeInformacion()
        {
            InitializeComponent();
        }



        private void frmTypeInformacion_Load(object sender, EventArgs e)
        {

        }

        internal void setData()
        {
            if (TypeInformacionID != string.Empty)
            {
                callApiTypeInformacion.urlApi = CollectAPI.GetTypeInformacion;
                callApiTypeInformacion.CallGet(TypeInformacionID);
                if (callApiTypeInformacion.objectResponse != null)
                {
                    txtDescripcion.Text = callApiTypeInformacion.objectResponse.Descripcion;
                    numOrden.Value = callApiTypeInformacion.objectResponse.Orden;
                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Agregar:
                    saveData(CollectAPI.InsertTypeInformacion);
                    break;
                case Modo.Editar:
                    saveData(CollectAPI.UpdateTypeInformacion);
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
            MngApiTypeInformacion.urlApi = urlApi;
            MngApiTypeInformacion.objectRequest = typeInformacion;
            MngApiTypeInformacion.CallPost();
            result = MngApiTypeInformacion.objectResponse;
        }

        private void prepareData()
        {
            if (modo == Modo.Editar)
            {
                typeInformacion.ID = TypeInformacionID;
            }

            typeInformacion.Descripcion = txtDescripcion.Text;
            typeInformacion.Orden = (int)numOrden.Value;
        }
    }
}
