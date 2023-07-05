using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi_CodeFirst.Classes;

namespace TelefonRehberi_CodeFirst.Context
{
    public class RehberContext : DbContext  
    {
        public DbSet<Kisi> Kisiler => Set<Kisi>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   "server=.; database=KisiRehberi2;trusted_connection=true");
        }
    }
}
