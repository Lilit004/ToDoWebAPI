using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoWebAPI.Domain.Entities;

namespace ToDoWebAPI.Infrastructure.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options):base(options)
        {
            
        }
        

        public DbSet<ToDo> ToDos { get; set; }

        public DbSet<ToDoStatus> ToDoStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().
                HasOne<ToDoStatus>(s => s.ToDoStatuses).
                WithMany(s => s.ToDos).
                HasForeignKey(s => s.ToDoStatusesId);
        }
    }
}
