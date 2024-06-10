using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Repository;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.DeleteToDo
{
    public class DeleteToDoCommandHandler : ICommandHandler<DeleteToDoCommand>
    {
        
        private readonly IToDoRepository _todorepository;
       
        public DeleteToDoCommandHandler(IToDoRepository todorepository)
        {
            _todorepository = todorepository;
            
        }

        

        public async Task HandleAsync(DeleteToDoCommand command, CancellationToken cancellationToken = default)
        {
             await _todorepository.DeleteToDo(command.ToDoId);
        }
    }
}
