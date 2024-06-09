using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    public class UpdateToDoCommandHandler : IRequestHandler<UpdateToDoCommand, int>
    {
        private readonly IToDoRepository _todorepository;
        private readonly IMapper _mapper;
        public UpdateToDoCommandHandler(IToDoRepository todorepository,IMapper mapper)
        {
            _todorepository = todorepository;
            _mapper = mapper;
        }
        public async  Task<int> Handle(UpdateToDoCommand request, CancellationToken cancellationToken)
        {
            var todo = new ToDo();
            todo.Id = request.Id;
            todo.Name = request.Name;
            if (request.Completed == true)
                todo.ToDoStatusesId = 1;
            else
                todo.ToDoStatusesId = 2;
            return await _todorepository.UpdateToDo(request.Id, todo);
        }
    }
}
