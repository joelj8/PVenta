using PVenta.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVenta.DAL
{
    public class DBPVentaContext: DbContext 
    {
        public DBPVentaContext(): base("PVentaDB")
        {
           
        }

        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<LogEvento> LogEventos { get; set; }
        public virtual DbSet<OpcionesSist> OpcionesSists { get; set; }
        public virtual DbSet<PermisosRol> PermisosRols { get; set; }
        public virtual DbSet<Mesa> Mesas { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<FacturaHeader> FacturaHeaders { get; set; }
        public virtual DbSet<FacturaDetail> FacturaDetails { get; set; }
        public virtual DbSet<FacturaPayment> FacturaPayments { get; set; }
        public virtual DbSet<CuadreHeader> CuadreHeaders { get; set; }
        public virtual DbSet<CuadreDetail> CuadreDetails { get; set; }
        public virtual DbSet<ErrorList> ErrorLists { get; set; }
        public virtual DbSet<FormaPago> FormaPagos { get; set; }
        public virtual DbSet<TypeInformacion> TypeInfos { get; set; }
        public virtual DbSet<InfoDigital> InfoDigitals { get; set; }
        public virtual DbSet<ConfigSistema> ConfigSistemas { get; set; }


    }
}
