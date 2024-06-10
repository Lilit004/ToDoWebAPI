using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.CreateToDo
{
    public class CreateToDoCommand : ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }


    }
}
