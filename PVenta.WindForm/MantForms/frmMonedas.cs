using PVenta.Utility;
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
    public partial class frmMonedas : FormGRLA
    {
        public Modo modo;

        public string MonedaID { get; internal set; }

        public frmMonedas()
        {
            InitializeComponent();
        }

        private void frmMonedas_Load(object sender, EventArgs e)
        {

        }

        internal void setData()
        {
            throw new NotImplementedException();
        }
    }
}
