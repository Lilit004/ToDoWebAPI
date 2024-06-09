using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;

namespace ToDoWebAPI.Domain.Repository
{
    public interface IToDoRepository
    {
        Task<List<ToDo>> GetToDos();
        Task<ToDo> GetToDoById(int id);
        Task<ToDo> CreateToDo(ToDo todo);
        Task<int> UpdateToDo(int id,ToDo toDo);
        Task<int> DeleteToDo(int id);
        

    }
}
