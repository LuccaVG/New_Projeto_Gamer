using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models.Infra
{
    public class Context : DbContext
    {
        public Context()
        {  
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-8UO2UT6; initial catalog = GamerTarde; integrated Security = true; TrustServerCertificate=true");
            }
            
        }
   public DbSet<Jogador> Jogador {get; set;}

    public DbSet<Equipe> Equipe {get; set;}
    
    }
}