using System.Collections.Generic;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
          {
               builder.Entity<Jogo>()
                      .HasData(new List<Jogo>(){
                   new Jogo(1,12,12,12,0,0),
                      });
          }        
    }
}