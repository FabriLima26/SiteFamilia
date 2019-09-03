using Microsoft.EntityFrameworkCore;
using SiteFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFamilia.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Mae> Maes { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
