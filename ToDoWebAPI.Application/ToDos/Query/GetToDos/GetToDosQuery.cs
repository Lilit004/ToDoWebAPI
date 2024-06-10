using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;
using Convey.CQRS.Queries;
namespace ToDoWebAPI.Application.ToDos.Query.GetToDos
    
{
    public class GetToDosQuery : IQuery<List<ToDoVm>>
    {
    }
}
