//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MuseoEntities : DbContext
    {
        public MuseoEntities()
            : base("metadata = res://*/Museo.csdl|res://*/Museo.ssdl|res://*/Museo.msl;provider=System.Data.SqlClient;provider connection string='Data Source=SQL5063.site4now.net;Initial Catalog=db_a7bfa6_musedsiultimaentre;User Id=db_a7bfa6_musedsiultimaentre_admin;Password=DSI20212021!'")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DetalleExposicion> DetalleExposicion { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Exposicion> Exposicion { get; set; }
        public DbSet<Obra> Obra { get; set; }
        public DbSet<ReservaVisita> ReservaVisita { get; set; }
        public DbSet<Sede> Sede { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<TipoEntrada> TipoEntrada { get; set; }
        public DbSet<TipoVisita> TipoVisita { get; set; }
    }
}
