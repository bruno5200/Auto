using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAuto.Entities;
using Microsoft;
using Microsoft.EntityFrameworkCore;

namespace ApiAuto.Contexts
{
    public class AppBDContext : DbContext
    {
        public AppBDContext(DbContextOptions<AppBDContext> options) : base(options)
        {
        }
        public DbSet<Auto> autos { get; set; }
        public DbSet<Tiempo> tiempo { get; set; }
        public DbSet<Usuario> usuarios { get; set }
    }
}