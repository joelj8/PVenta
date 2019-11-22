using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.Utility
{
    public static class CollectAPI
    {
        #region LogIn
        public static string SignIn
        {
            get { return "api/Login/singin"; }
        }
        #endregion

        #region ErrorList
        public static string GetErrorLists
        {
            get { return "api/ErrorList/GetErrorLists"; }
        }
        public static string GetErrorList
        {
            get { return "api/ErrorList/GetErrorList/"; }
        }
        public static string InsertErrorList
        {
            get { return "api/ErrorList/InsertErrorList"; }
        }
        public static string UpdateErrorList
        {
            get { return "api/ErrorList/UpdateErrorList"; }
        }
        public static string DeleteErrorList
        {
            get { return "api/ErrorList/DeleteErrorList/"; }
        }
        #endregion

        #region LogEvento
        public static string GetLoegEventos
        {
            get { return "api/LogEvento/GetLoegEventos"; }
        }
        public static string GetLoegEvento
        {
            get { return "api/LogEvento/GetLoegEvento/"; }
        }
        public static string InsertLoegEvento
        {
            get { return "api/LogEvento/InsertLoegEvento"; }
        }
        public static string UpdateLoegEvento
        {
            get { return "api/LogEvento/UpdateLoegEvento"; }
        }

        #endregion

        #region Rol
        public static string GetRoles {
            get { return "api/Rol/GetRoles"; } }

        public static string GetRol
        {
            get { return "api/Rol/GetRol/"; }
        }
        public static string InsertRol
        {
            get { return "api/Rol/InsertRol"; }
        }
        public static string UpdateRol
        {
            get { return "api/Rol/UpdateRol"; }
        }
        public static string DeleteRol
        {
            get { return "api/Rol/DeleteRol/"; }
        }
        #endregion

        #region Usuario
        public static string GetUsuarios
        {
            get { return "api/Usuario/GetUsuarios"; }
        }
        public static string GetUsuario
        {
            get { return "api/Usuario/GetUsuario/"; }
        }
        public static string InsertUsuario
        {
            get { return "api/Usuario/InsertUsuario"; }
        }
        public static string UpdateUsuario
        {
            get { return "api/Usuario/UpdateUsuario"; }
        }
        public static string DeleteUsuario
        {
            get { return "api/Usuario/DeleteUsuario/"; }
        }
        #endregion

        #region OpcionesSist
        public static string GetOpcionesSists
        {
            get { return "api/OpcionesSist/GetOpcionesSists"; }
        }
        public static string GetOpcionesSist
        {
            get { return "api/OpcionesSist/GetOpcionesSist/"; }
        }
        public static string InsertOpcionesSist
        {
            get { return "api/OpcionesSist/InsertOpcionesSist"; }
        }
        public static string UpdateOpcionesSist
        {
            get { return "api/OpcionesSist/UpdateOpcionesSist"; }
        }
        public static string DeleteOpcionesSist
        {
            get { return "api/OpcionesSist/DeleteOpcionesSist/"; }
        }
        #endregion

        #region PermisosRol
        public static string GetPermisosRoles
        {
            get { return "api/PermisosRol/GetPermisosRoles"; }
        }
        public static string GetPermisosRol
        {
            get { return "api/PermisosRol/GetPermisosRol/"; }
        }
        public static string InsertPermisosRol
        {
            get { return "api/PermisosRol/InsertPermisosRol"; }
        }
        public static string UpdatePermisosRol
        {
            get { return "api/PermisosRol/UpdatePermisosRol"; }
        }
        public static string DeletePermisosRol
        {
            get { return "api/PermisosRol/DeletePermisosRol/"; }
        }
        #endregion

        #region Mesa
        public static string GetMesas
        {
            get { return "api/Mesa/GetMesas"; }
        }
        public static string GetMesa
        {
            get { return "api/Mesa/GetMesa/"; }
        }
        public static string InsertMesa
        {
            get { return "api/Mesa/InsertMesa"; }
        }
        public static string UpdateMesa
        {
            get { return "api/Mesa/UpdateMesa"; }
        }
        public static string DeleteMesa
        {
            get { return "api/Mesa/DeleteMesa/"; }
        }
        #endregion

        #region Moneda
        public static string GetMonedas
        {
            get { return "api/Moneda/GetMonedas"; }
        }
        public static string GetMoneda
        {
            get { return "api/Moneda/GetMoneda/"; }
        }
        public static string InsertMoneda
        {
            get { return "api/Moneda/InsertMoneda"; }
        }
        public static string UpdateMoneda
        {
            get { return "api/Moneda/UpdateMoneda"; }
        }
        public static string DeleteMoneda
        {
            get { return "api/Moneda/DeleteMoneda/"; }
        }
        #endregion

        #region FormaPago
        public static string GetFormaPagos
        {
            get { return "api/FormaPago/GetFormaPagos"; }
        }
        public static string GetFormaPago
        {
            get { return "api/FormaPago/GetFormaPago/"; }
        }
        public static string InsertFormaPago
        {
            get { return "api/FormaPago/InsertFormaPago"; }
        }
        public static string UpdateFormaPago
        {
            get { return "api/FormaPago/UpdateFormaPago"; }
        }
        public static string DeleteFormaPago
        {
            get { return "api/FormaPago/DeleteFormaPago/"; }
        }
        #endregion

        #region Categoria
        public static string GetCategorias
        {
            get { return "api/Categoria/GetCategorias"; }
        }
        public static string GetCategoria
        {
            get { return "api/Categoria/GetCategoria/"; }
        }
        public static string InsertCategoria
        {
            get { return "api/Categoria/InsertCategoria"; }
        }
        public static string UpdateCategoria
        {
            get { return "api/Categoria/UpdateCategoria"; }
        }
        public static string DeleteCategoria
        {
            get { return "api/Categoria/DeleteCategoria/"; }
        }
        #endregion

        #region Producto
        public static string GetProductos
        {
            get { return "api/Producto/GetProductos"; }
        }
        public static string GetProducto
        {
            get { return "api/Producto/GetProducto/"; }
        }
        public static string InsertProducto
        {
            get { return "api/Producto/InsertProducto"; }
        }
        public static string UpdateProducto
        {
            get { return "api/Producto/UpdateProducto"; }
        }
        public static string DeleteProducto
        {
            get { return "api/Producto/DeleteProducto/"; }
        }
        #endregion

        #region Order
        public static string GetOrders
        {
            get { return "api/Order/GetOrders"; }
        }
        public static string GetOrder
        {
            get { return "api/Order/GetOrder/"; }
        }
        public static string InsertOrder
        {
            get { return "api/Order/InsertOrder"; }
        }
        public static string UpdateOrder
        {
            get { return "api/Order/UpdateOrder"; }
        }
        public static string DeleteOrder
        {
            get { return "api/Order/DeleteOrder/"; }
        }
        #endregion

    }
}
