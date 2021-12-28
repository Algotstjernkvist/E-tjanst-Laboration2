using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WcfLagerService1
{
    public partial class LagerModel : DbContext // Dbcontext hj�lper mig att kommunicera med databas
    {                                           // Lagermodel �r objekt som hj�lper mig kommunicera
        public LagerModel()
            : base("name=LagerModel")
        {
        }

        public virtual DbSet<Lager> Lager { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lager>()
                .Property(e => e.Varunamn)
                .IsUnicode(false);
        }
    }
}
