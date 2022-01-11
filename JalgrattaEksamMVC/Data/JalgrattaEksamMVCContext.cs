using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JalgrattaEksamMVC.Models;

namespace JalgrattaEksamMVC.Data
{
    public class JalgrattaEksamMVCContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Eksam>()
                .HasIndex(e => new { e.Eesnimi, e.Perekonnanimi})
                .IsUnique();
        }
        public JalgrattaEksamMVCContext (DbContextOptions<JalgrattaEksamMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JalgrattaEksamMVC.Models.Eksam> Eksam { get; set; }
    }
}
