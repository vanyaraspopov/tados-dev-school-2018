using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task2
{
    public class ModelsContext : DbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryVar>()
                .HasOne(p => p.Category);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryVar> CategoryVars { get; set; }
        public DbSet<CategoryVarValue> CategoryVarsValues { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentRate> ContentRates { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class ModelsContextFactory : IDesignTimeDbContextFactory<ModelsContext>
    {
        public ModelsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ModelsContext>();
            optionsBuilder.UseSqlServer(Startup.DbConnectionString);

            return new ModelsContext(optionsBuilder.Options);
        }
    }
}
