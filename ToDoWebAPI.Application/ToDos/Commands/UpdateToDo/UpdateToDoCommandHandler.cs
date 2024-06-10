using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    public class UpdateToDoCommandHandler : ICommandHandler<UpdateToDoCommand>
    {
        private readonly IToDoRepository _todorepository;
        
        public UpdateToDoCommandHandler(IToDoRepository todorepository)
        {
            _todorepository = todorepository;
            
        }
        

        public async Task HandleAsync(UpdateToDoCommand command, CancellationToken cancellationToken = default)
        {
            var todo = new ToDo();
            todo.Id = command.Id;
            todo.Name = command.Name;
            if (command.Completed == true)
                todo.ToDoStatusesId = 1;
            else
                todo.ToDoStatusesId = 2;
            await _todorepository.UpdateToDo(command.Id, todo);
        }
    }
}
