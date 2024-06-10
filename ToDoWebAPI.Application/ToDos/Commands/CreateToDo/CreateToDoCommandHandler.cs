using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Application.ToDos.Query.GetToDoById;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;
using Convey.CQRS.Commands;

namespace ToDoWebAPI.Application.ToDos.Commands.CreateToDo
{
    public class CreateToDoCommandHandler : ICommandHandler<CreateToDoCommand>
    {
       
            private readonly IToDoRepository _todorepository;
            private readonly IMapper _mapper;

            public CreateToDoCommandHandler(IToDoRepository todorepository, IMapper mapper)
            {
                _todorepository = todorepository;
                _mapper = mapper;
            }
            

        public async Task HandleAsync(CreateToDoCommand command, CancellationToken cancellationToken = default)
        {
            var todo = new ToDo();
            todo.Id = command.Id;
            todo.Name = command.Name;
            if (command.Completed)
            {
                todo.ToDoStatusesId = 1;
            }
            else
            {
                todo.ToDoStatusesId = 2;
            }
            var result = await _todorepository.CreateToDo(todo);
            
        }
    }
}
