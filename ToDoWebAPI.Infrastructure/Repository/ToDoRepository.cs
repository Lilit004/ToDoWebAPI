using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;
using ToDoWebAPI.Infrastructure.Data;


namespace ToDoWebAPI.Infrastructure.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ToDoDbContext _context;

        public ToDoRepository(ToDoDbContext context)
        {
            _context = context;
        }
        public async Task<ToDo> CreateToDo(ToDo todo)
        {
            await _context.ToDos.AddAsync(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<int> DeleteToDo(int id)
        {
            return await _context.ToDos.Where(model => model.Id == id).ExecuteDeleteAsync();
        }

        public async Task<ToDo> GetToDoById(int id)
        {
            return await _context.ToDos.AsNoTracking().FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<List<ToDo>> GetToDos()
        {
            return await _context.ToDos.ToListAsync();
        }

        public async Task<int> UpdateToDo(int id, ToDo toDo)
        {
            var todo = await _context.ToDos.FindAsync(id);
            if (todo != null)
            {
                todo.Name = toDo.Name;
                todo.ToDoStatusesId = toDo.ToDoStatusesId;
            }
            return await _context.SaveChangesAsync();
            
        }
    }
}
