﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqSorgularABarcin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Slytherin_AracIhaleEntities : DbContext
    {
        public Slytherin_AracIhaleEntities()
            : base("name=Slytherin_AracIhaleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ArabaModel> ArabaModel { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracFiyat> AracFiyat { get; set; }
        public virtual DbSet<AracOzellik> AracOzellik { get; set; }
        public virtual DbSet<AracParca> AracParca { get; set; }
        public virtual DbSet<AracStatu> AracStatu { get; set; }
        public virtual DbSet<AracTeklif> AracTeklif { get; set; }
        public virtual DbSet<AracTramer> AracTramer { get; set; }
        public virtual DbSet<AracTramerDetay> AracTramerDetay { get; set; }
        public virtual DbSet<Calisan> Calisan { get; set; }
        public virtual DbSet<CalisanIletisim> CalisanIletisim { get; set; }
        public virtual DbSet<Ekspertiz> Ekspertiz { get; set; }
        public virtual DbSet<FavoriArama> FavoriArama { get; set; }
        public virtual DbSet<FavoriAramaKriter> FavoriAramaKriter { get; set; }
        public virtual DbSet<FavoriIlan> FavoriIlan { get; set; }
        public virtual DbSet<FavoriOzellik> FavoriOzellik { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<FirmaIletisim> FirmaIletisim { get; set; }
        public virtual DbSet<FirmaTip> FirmaTip { get; set; }
        public virtual DbSet<Fotograf> Fotograf { get; set; }
        public virtual DbSet<Ihale> Ihale { get; set; }
        public virtual DbSet<IhaleArac> IhaleArac { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatu { get; set; }
        public virtual DbSet<IhaleSurec> IhaleSurec { get; set; }
        public virtual DbSet<Ilan> Ilan { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<IletisimTur> IletisimTur { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciIletisim> KullaniciIletisim { get; set; }
        public virtual DbSet<KullaniciTip> KullaniciTip { get; set; }
        public virtual DbSet<KurumsalIhale> KurumsalIhale { get; set; }
        public virtual DbSet<KurumsalKullanici> KurumsalKullanici { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Ozellik> Ozellik { get; set; }
        public virtual DbSet<OzellikBilgi> OzellikBilgi { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolYetki> RolYetki { get; set; }
        public virtual DbSet<Sayfa> Sayfa { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<SehirIlce> SehirIlce { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TramerDetay> TramerDetay { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
    }
}