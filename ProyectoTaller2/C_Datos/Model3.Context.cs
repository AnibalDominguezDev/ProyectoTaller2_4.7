﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTaller2.C_Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TALLER2CSEntities3 : DbContext
    {
        public TALLER2CSEntities3()
            : base("name=TALLER2CSEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria_productos> categoria_productos { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<rol_usuario> rol_usuario { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<venta_detalle> venta_detalle { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }
    }
}
