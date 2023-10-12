using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Models;

namespace TodoList.Infrastructure.Data
{
    public class DbContextTodoList : DbContext
    {
        public DbContextTodoList(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }
        //public DbSet<Category> Categories { get; set; } 
        //public DbSet<Status> Statuses { get; set; }  

    }
}
