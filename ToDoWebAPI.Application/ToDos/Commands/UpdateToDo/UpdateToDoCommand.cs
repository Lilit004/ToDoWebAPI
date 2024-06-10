using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    public class UpdateToDoCommand : ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}
