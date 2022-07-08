using Microsoft.EntityFrameworkCore;
using Prj01.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj01.DL
{
    public class Prj01DbContext : DbContext
    {
        public DbSet<TestDbModel> Tests => Set<TestDbModel>();
        public DbSet<QuestionDbModel> Questions => Set<QuestionDbModel>();
        public DbSet<VariantDbModel> Variants => Set<VariantDbModel>();
        public Prj01DbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\DataBase\Prj01.db");
        }
    }
}
