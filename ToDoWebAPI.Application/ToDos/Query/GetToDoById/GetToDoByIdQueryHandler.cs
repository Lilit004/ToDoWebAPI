using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;

namespace ToDoWebAPI.Application.ToDos.Query.GetToDoById
{
    public class GetToDoByIdQueryHandler : IRequestHandler<GetToDoByIdQuery, ToDoVm>
    {
        private readonly IToDoRepository _todorepository;
        private readonly IMapper _mapper;

        public GetToDoByIdQueryHandler(IToDoRepository todorepository, IMapper mapper)
        {
            _todorepository = todorepository;
            _mapper = mapper;
        }
        public async Task<ToDoVm> Handle(GetToDoByIdQuery request, CancellationToken cancellationToken)
        {
            var todo = await _todorepository.GetToDoById(request.ToDoId);
            var todoVm = _mapper.Map<ToDoVm>(todo);
            return todoVm;
        }
    }
}
