using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Domain.Repository;

namespace ToDoWebAPI.Application.ToDos.Query.GetToDoById
{
    internal class GetToDoByIdValidator : AbstractValidator<GetToDoByIdQuery>
    {
        public GetToDoByIdValidator(IToDoRepository todorepository)
        {
            RuleFor(x => x.ToDoId).Must((id) =>
            {
                var result = todorepository.GetToDoById(id).Result;
                return result != null;
            }).WithMessage("Todo not found");
        }
    }
}
