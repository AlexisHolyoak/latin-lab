﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace latin_lab.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicaDBEntities : DbContext
    {
        public ClinicaDBEntities()
            : base("name=ClinicaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Clases> Clases { get; set; }
        public virtual DbSet<Cpts> Cpts { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Descuentos> Descuentos { get; set; }
        public virtual DbSet<Distritos> Distritos { get; set; }
        public virtual DbSet<Egresos> Egresos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Incentivos> Incentivos { get; set; }
        public virtual DbSet<Ingresos> Ingresos { get; set; }
        public virtual DbSet<Muestras> Muestras { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<RazonesFinancieras> RazonesFinancieras { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<SubClases> SubClases { get; set; }
        public virtual DbSet<Sueldos> Sueldos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tarifas> Tarifas { get; set; }
        public virtual DbSet<TipoAydDiags> TipoAydDiags { get; set; }
        public virtual DbSet<TiposTrabajador> TiposTrabajador { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }
        public virtual DbSet<UnidadesMedida> UnidadesMedida { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<TrabajadorDescuentos> TrabajadorDescuentos { get; set; }
        public virtual DbSet<TrabajadorIncentivo> TrabajadorIncentivo { get; set; }
    }
}
