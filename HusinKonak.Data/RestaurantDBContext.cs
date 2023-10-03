﻿using HusinKonak.Data.Modul0_Autentifikacija.Models;
using HusinKonak.Data.Modul2.Models;
using Microsoft.EntityFrameworkCore;

namespace HusinKonak.Data
{
    public class RestaurantDBContext : DbContext
    {
        public RestaurantDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<AutentifikacijaToken> AutentifikacijaToken { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<LogKretanjePoSistemu> LogKretanjePoSistemu { get; set; }
        public DbSet<Kontakt> Kontakt { get; set; }
        public DbSet<Galerija> Galerija{ get; set; }
        
    }
}
