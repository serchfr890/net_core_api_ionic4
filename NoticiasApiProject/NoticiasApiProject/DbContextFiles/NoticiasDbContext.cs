using Microsoft.EntityFrameworkCore;
using NoticiasApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasApiProject.DbContextFiles
{
    public class NoticiasDbContext : DbContext
    {
        protected NoticiasDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Noticia.Mapeo(modelBuilder.Entity<Noticia>());
            new Autor.Mapeo(modelBuilder.Entity<Autor>());
        }
    }
}
