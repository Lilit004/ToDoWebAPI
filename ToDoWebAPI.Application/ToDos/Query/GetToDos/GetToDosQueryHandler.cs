using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Repository;
using ToDoWebAPI.Domain.Entities;
using Convey.CQRS.Queries;

namespace ToDoWebAPI.Application.ToDos.Query.GetToDos
{
    public class GetToDosQueryHandler : IQueryHandler<GetToDosQuery, List<ToDoVm>>
    {
        private readonly IToDoRepository _todorepository;
        private readonly IMapper _mapper;
        

        public GetToDosQueryHandler(IToDoRepository todorepository,IMapper mapper)
        {
            _todorepository = todorepository;
            _mapper = mapper;
            
        }
       

        public async Task<List<ToDoVm>> HandleAsync(GetToDosQuery query, CancellationToken cancellationToken = default)
        {
            var todos = await _todorepository.GetToDos();
            var todoList = _mapper.Map<List<ToDoVm>>(todos);
            return todoList;
        }
    }
}

