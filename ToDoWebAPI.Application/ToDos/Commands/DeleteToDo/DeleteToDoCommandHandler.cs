using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Repository;

namespace ToDoWebAPI.Application.ToDos.Commands.DeleteToDo
{
    public class DeleteToDoCommandHandler : IRequestHandler<DeleteToDoCommand, int>
    {
        
        private readonly IToDoRepository _todorepository;
        private readonly IMapper _mapper;
        public DeleteToDoCommandHandler(IToDoRepository todorepository, IMapper mapper)
        {
            _todorepository = todorepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(DeleteToDoCommand request, CancellationToken cancellationToken)
        {
            return await _todorepository.DeleteToDo(request.ToDoId);
        }
    }
}
