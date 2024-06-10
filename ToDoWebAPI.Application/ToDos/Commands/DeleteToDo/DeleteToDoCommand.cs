using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.DeleteToDo
{
    public class DeleteToDoCommand : ICommand
    {
        public int ToDoId { get; set; }
    }
}
