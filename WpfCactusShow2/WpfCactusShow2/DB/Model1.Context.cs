﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfCactusShow2.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kaktus_vistavkaEntities : DbContext
    {
        public Kaktus_vistavkaEntities()
            : base("name=Kaktus_vistavkaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cactus> Cactus { get; set; }
        public virtual DbSet<Kind> Kind { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<Show_cactus> Show_cactus { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
