using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList5.Models
{
    public class GoalsDBContext : DbContext
    {
        public DbSet<Goal> Goals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=GoalsDB;Integrated Security=True");
        }
    }
}
