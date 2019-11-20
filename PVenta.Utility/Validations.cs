using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVenta.Utility
{
    public static class Validations
    {
        public static bool validarID(string idvalidar, string msg)
        {
            bool returnResult = true;
            if (idvalidar == null || idvalidar == string.Empty)
            {
                returnResult = false;
                if (msg != null && msg != string.Empty)
                {
                    MessageBox.Show(msg, "Validación...");
                }
            }
            return returnResult;
        }
    }
}
