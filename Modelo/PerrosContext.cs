using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;

namespace perros_app_api.Modelo
{


    public class PerrosContext : DbContext
    {
        public PerrosContext(DbContextOptions<PerrosContext> options) : base(options)
        {
        }

        public DbSet<Perro> Perros { get; set; }

    }

}