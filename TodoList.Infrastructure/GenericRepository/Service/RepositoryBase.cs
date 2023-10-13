using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoList.Infrastructure.Data;
using TodoList.Infrastructure.GenericRepository.Interface;

namespace TodoList.Infrastructure.GenericRepository.Service
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DbContextTodoList DbContextTodoList;
        public RepositoryBase(DbContextTodoList dbContextTodoList)
        {
            DbContextTodoList = dbContextTodoList;
        }
        public async Task<IQueryable<T>> FindAllAsync(bool trackChanges) =>
      !trackChanges ? await Task.Run(() => DbContextTodoList.Set<T>().AsNoTracking()) : await Task.Run(() => DbContextTodoList.Set<T>());

        public async Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? await Task.Run(() => DbContextTodoList.Set<T>().Where(expression).AsNoTracking()) : await Task.Run(() => DbContextTodoList.Set<T>().Where(expression));

        public async Task CreateAsync(T entity) => await Task.Run(() => DbContextTodoList.Set<T>().Add(entity));

        public async Task UpdateAsync(T entity) => await Task.Run(() => DbContextTodoList.Set<T>().Update(entity));
        public async Task RemoveAsync(T entity) => await Task.Run(() => DbContextTodoList.Set<T>().Remove(entity));
    }
}
