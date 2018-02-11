using Microsoft.EntityFrameworkCore;
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

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryVar> CategoryVars { get; set; }
        public DbSet<CategoryVarValue> CategoryVarsValues { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentRate> ContentRates { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
