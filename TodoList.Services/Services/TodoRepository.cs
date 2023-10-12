using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Models;
using TodoList.Infrastructure.Data;
using TodoList.Services.Interfaces;

namespace TodoList.Services.Services
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(DbContextTodoList dbContextTodoList) : base(dbContextTodoList) { }
    }
}
