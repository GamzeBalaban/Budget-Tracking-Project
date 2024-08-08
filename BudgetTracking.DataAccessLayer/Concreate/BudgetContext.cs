using BudgetTracking.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.DataAccessLayer.Concreate
{
    public class BudgetContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-I7BINER\\SQLEXPRESS;initial Catalog=BudgetTrackingDB;integrated Security=true;TrustServerCertificate=True");

        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expenses> Expensess { get; set; }
        public DbSet<Level> Levels{ get; set; }
        public DbSet<SubLevel> SubLevels{ get; set; }
        public DbSet<CompanyName> CompanyNames { get; set; }
        public DbSet<WorkDone> WorkDones { get; set; }
        public DbSet<WorkDoneType> WorkDoneTypes { get; set; }
        public DbSet<VAT> VATs { get; set; }
        public DbSet<Planning> Plannings { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<AppControl> AppControls { get; set; }
        public DbSet<Realization> Realizations { get; set; }
        public DbSet<BudgetAmount> BudgetAmounts { get; set; }
        public DbSet<Refuse> Refuses { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<User> Users { get; set; }
      

    }
}
