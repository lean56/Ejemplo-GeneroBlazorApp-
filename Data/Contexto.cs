using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeneroBlazorApp.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Genero> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=EMIL56\SQLEXPRESS; Database =TestDb;Trusted_Connection =true");
        }

    }



    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
    }
}
