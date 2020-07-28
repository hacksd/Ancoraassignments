using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace lab11_5
{
    class SakilaContext : DbContext
    {
       public DbSet <Actor> Actor { get; set; }
        public DbSet<Film> Film { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder )
        {
            OptionsBuilder.UseSqlServer(@"server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }
    }
}
