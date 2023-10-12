using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Core.Models;

namespace TodoList.Services.Interfaces
{
    public interface ITodoRepository
    {
        Task<Todo> GetTodo(int id);
        Task<List<Todo>> GetAll();
        Task CreateTodoList(Todo todo);
    }
}
