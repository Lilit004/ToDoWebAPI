using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWebAPI.Application.ToDos.Commands.DeleteToDo
{
    public class DeleteToDoCommand : IRequest<int>
    {
        public int ToDoId { get; set; }
    }
}
