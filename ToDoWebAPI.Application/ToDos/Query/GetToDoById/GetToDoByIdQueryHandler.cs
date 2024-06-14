using AutoMapper;
using Convey.CQRS.Queries;
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
    public class GetToDoByIdQueryHandler : IQueryHandler<GetToDoByIdQuery, ToDoVm>
    {
        private readonly IToDoRepository _todorepository;
        private readonly IMapper _mapper;

        public GetToDoByIdQueryHandler(IToDoRepository todorepository, IMapper mapper)
        {
            _todorepository = todorepository;
            _mapper = mapper;
        }
        

        public async Task<ToDoVm> HandleAsync(GetToDoByIdQuery query, CancellationToken cancellationToken = default)
        {
            var todo = await _todorepository.GetToDoById(query.ToDoId);
            var todoVm = _mapper.Map<ToDoVm>(todo);
            return todoVm;
            
        }
    }
}
