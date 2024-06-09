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

namespace ToDoWebAPI.Application.ToDos.Commands.CreateToDo
{
    public class CreateToDoCommandHandler : IRequestHandler<CreateToDoCommand, ToDoVm>
    {
       
            private readonly IToDoRepository _todorepository;
            private readonly IMapper _mapper;

            public CreateToDoCommandHandler(IToDoRepository todorepository, IMapper mapper)
            {
                _todorepository = todorepository;
                _mapper = mapper;
            }
            public async  Task<ToDoVm> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
            {
                var todo = new ToDo();
                todo.Id = request.Id;
                todo.Name = request.Name;
                if(request.Completed)
                {
                    todo.ToDoStatusesId = 1;
                }
                else
                {
                    todo.ToDoStatusesId = 2;
                }
                var result = await _todorepository.CreateToDo(todo);
                return  _mapper.Map<ToDoVm>(result);
                
            }
    }
}
