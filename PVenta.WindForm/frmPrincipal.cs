using PVenta.Models.ViewModel;
using PVenta.WindForm.AdmForms;
using PVenta.WindForm.Define;
using PVenta.WindForm.MantForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVenta.WindForm
{
    public partial class frmPrincipal : FormGRLA
    {
        public viewLogin userApp = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.ShowDialog();
            if (flogin.userSignIn != null)
            {
                this.Text = "PVenta - " + flogin.userSignIn.Nombre.ToUpper();
                userApp = new viewLogin();
                userApp.UserID = flogin.userSignIn.UserID;
                userApp.ID = flogin.userSignIn.ID;
                userApp.Nombre = flogin.userSignIn.Nombre;
                userApp.Email = flogin.userSignIn.Email;
                userApp.esCajero = flogin.userSignIn.esCajero;
                userApp.RolID = flogin.userSignIn.RolID;

                muestraMenu();

            } 
            else
            {
                this.Close();
            }

            flogin.Dispose();

        }

        private void muestraMenu()
        {
            if (userApp.esCajero)
            {
                // Mostrar el menu para los cajeros
                menCajeros.Visible = true;
            } else
            {
                menAdministrativo.Visible = true;
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRolesAdm fRolesAdm = new frmRolesAdm();
            fRolesAdm.ShowDialog();
            fRolesAdm.Dispose();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuariosAdm fUsuariosAdm = new frmUsuariosAdm();
            fUsuariosAdm.ShowDialog();
            fUsuariosAdm.Dispose();
        }

        private void mesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMesasAdm fMesasAdm = new frmMesasAdm();
            fMesasAdm.ShowDialog();
            fMesasAdm.Dispose();
        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonedasAdm fMonedasAdm = new frmMonedasAdm();
            fMonedasAdm.ShowDialog();
            fMonedasAdm.Dispose();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormaPagosAdm fFormaPagosAdm = new frmFormaPagosAdm();
            fFormaPagosAdm.ShowDialog();
            fFormaPagosAdm.Dispose();
        }
    }
}
