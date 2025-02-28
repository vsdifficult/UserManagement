using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Mvc;
using UsrManagemt.Models;

namespace UsrManagemt.Database 
{ 
    public class DataBaseContext : DbContext 
    { 
        public DbSet<User> Users {get; set; } 
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base (options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<User>().HasNoKey(); 
        }
    }
}