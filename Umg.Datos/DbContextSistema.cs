using Microsoft.EntityFrameworkCore;
using Umg.Datos.Mapping.Almacen;
using Umg.Datos.Mapping.Compras;
using Umg.Datos.Mapping.Usuarios;
using Umg.Datos.Mapping.Ventas;
using Umg.Entidades.Almacen;
using Umg.Entidades.Compras;
using Umg.Entidades.Usuarios;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<DetalleIngreso> DetalleIngresos { get; set; }
        public DbSet<EstadoIngreso> EstadoIngresos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<EstadoVenta> EstadoVentas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticuloMap());
            modelBuilder.ApplyConfiguration(new ComprobanteMap());
            modelBuilder.ApplyConfiguration(new DocumentoMap());
            modelBuilder.ApplyConfiguration(new TipoDocumentoMap());
            modelBuilder.ApplyConfiguration(new TipoComprobanteMap());
            modelBuilder.ApplyConfiguration(new DetalleIngresoMap());
            modelBuilder.ApplyConfiguration(new EstadoIngresoMap());
            modelBuilder.ApplyConfiguration(new IngresoMap());
            modelBuilder.ApplyConfiguration(new PersonaMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new TipoPersonaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new DetalleVentaMap());
            modelBuilder.ApplyConfiguration(new EstadoVentaMap());
            modelBuilder.ApplyConfiguration(new VentaMap());

        }
    }
}

