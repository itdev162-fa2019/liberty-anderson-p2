using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext: DbContext
    {
       // public DbSet<Value> Values { get; set; }   
        public DbSet<Expense> Expenses { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* 
            modelBuilder.Entity<Value>().HasData(
                new Value {Id = 1, Name = "Value1"},
                new Value {Id = 2, Name = "Value2"},
                new Value {Id = 3, Name = "Value3"}
            );
            */
            modelBuilder.Entity<Expense>().HasData(
                new Expense {ID = 1, Category = "Entertainment", Amount = 25.32m, Date = DateTime.Now},
                new Expense {ID = 2, Category = "Food", Amount = 78.65m, Date = DateTime.Now},
                new Expense {ID = 3, Category = "Bills", Amount = 152.26m, Date = DateTime.Now}
            );

        }
    }
}