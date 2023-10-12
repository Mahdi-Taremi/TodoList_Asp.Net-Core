using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Infrastructure.Data;
using TodoList.Services.Interfaces;

namespace TodoList.Services.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        private DbContextTodoList _dbContextTodoList;
        private ITodoRepository _todoRepository;
        private IConfiguration _configuration;

        public RepositoryManager(DbContextTodoList dbContextTodoList, IConfiguration configuration)
        {
            _dbContextTodoList = dbContextTodoList;
            _configuration = configuration; 

        }
        public ITodoRepository Todo
        { 
            get {
                //if (_todoRepository is null)
                if (_todoRepository == null)
                    _todoRepository = new TodoRepository(_dbContextTodoList);
                return _todoRepository; 
            }

        }
        public Task SaveAsync() => _dbContextTodoList.SaveChangesAsync();   
    }
}
