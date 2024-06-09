using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Entities;

namespace ToDoWebAPI.Application.ToDos.Query.GetToDoById
{
    public class GetToDoByIdQuery : IRequest<ToDoVm>
    {
        public int ToDoId { get; set; }
    }
}
