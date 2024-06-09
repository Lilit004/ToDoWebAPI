using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    public class UpdateToDoCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}
