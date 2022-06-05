using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Actor> Actors { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-3E8OOLTV\\MSSQLSERVER02;database=ProjectDb;trusted_connection=true;");
        }
    }
}
