using Convey.CQRS.Queries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Application.ToDos.Commands.CreateToDo;
using ToDoWebAPI.Application.ToDos.Query.GetToDoById;
using ToDoWebAPI.Domain.Entities;
using ToDoWebAPI.Domain.Repository;
using Convey.CQRS.Commands;
using FluentValidation.Results;


namespace ToDoWebAPI.Application.ToDos.Commands.DeleteToDo
{
    public class DeleteToDoCommandValidator : AbstractValidator<DeleteToDoCommand>
    {
       
        public DeleteToDoCommandValidator(IToDoRepository todoRepository)
        {

            RuleFor(x => x.ToDoId).Must(y => {

                var res = todoRepository.GetToDoById(y).Result;
                return res != null;
            }).WithMessage("Todo not found");
        }
        

    }
}
