using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Models;
using TodoList.Infrastructure.Data;
using TodoList.Infrastructure.GenericRepository.Service;
using TodoList.Services.Interfaces;

namespace TodoList.Services.Services
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(DbContextTodoList dbContextTodoList) : base(dbContextTodoList) { }

        public async Task CreateTodoList(Todo todo)
        {
            if (todo == null)   
            {
                await CreateAsync(todo);
            }
        }

        public async Task<Todo?> GetTodo(int id, bool trackChanges)
     => await FindByConditionAsync(e => e.Id.Equals(id), trackChanges).Result.SingleOrDefaultAsync();
        public Task<List<Todo>> GetAll()
        {
            throw new NotImplementedException();
        }

      
    }
}
