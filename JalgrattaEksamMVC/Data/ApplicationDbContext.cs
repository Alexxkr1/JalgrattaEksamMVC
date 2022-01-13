using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using JalgrattaEksamMVC.Models;

namespace JalgrattaeksamMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Eksam>()
                .HasIndex(e => new { e.Eesnimi, e.Perekonnanimi })
                .IsUnique();
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JalgrattaeksamMVC.Models.Eksam> Eksam { get; set; }
    }
}
