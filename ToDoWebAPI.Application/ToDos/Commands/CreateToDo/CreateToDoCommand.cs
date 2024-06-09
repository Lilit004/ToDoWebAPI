using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;

namespace ToDoWebAPI.Application.ToDos.Commands.CreateToDo
{
    public class CreateToDoCommand : IRequest<ToDoVm>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}
