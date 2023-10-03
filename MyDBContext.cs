using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Werken_Met_Data
{
    internal class MyDBContext:DbContext
    {

        public DbSet<Klant> Klanten {  get; set; }
        public DbSet<KlantenCategorie> KlantenCategorieen { get; set; }


        public void InitiateDatabase()
        {
            KlantenCategorie kc = new KlantenCategorie () { Naam = "Dummy" };
            if (!KlantenCategorieen.Any())
            {
                KlantenCategorieen.Add(kc);
            }
            else
            {
                kc = KlantenCategorieen.First();
            }
            if (!Klanten.Any()) { 
            Klant klant = new Klant()
            {
                Geboortedatum = DateTime.Now,
                Naam = "Dummy",
                Voornaam = "Paco"
            };
            Klanten.Add(klant);
            SaveChanges();
            }
            
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EvenTesten;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true");

        }
    }
}