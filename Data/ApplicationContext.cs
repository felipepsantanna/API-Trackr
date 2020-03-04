using API.TRACKR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TRACKR.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NivelDoUsuario>().HasKey(n => n.ID);

            modelBuilder.Entity<Time>().HasKey(t => t.ID);

            modelBuilder.Entity<Usuario>().HasKey(u => u.ID);
            modelBuilder.Entity<Usuario>().HasOne(u => u.Nivel);



        }
    }
}
