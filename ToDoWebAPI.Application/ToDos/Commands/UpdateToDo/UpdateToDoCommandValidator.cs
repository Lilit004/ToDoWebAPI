using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Application.ToDos.Commands.CreateToDo;
using ToDoWebAPI.Domain.Repository;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    internal class UpdateToDoCommandValidator : AbstractValidator<UpdateToDoCommand>
    {
        public UpdateToDoCommandValidator(IToDoRepository todorepository)
        {
            RuleFor(v => v.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(v => v.Completed).NotEmpty().WithMessage("Status is required");
            RuleFor(x => x.Id).Must((id) =>
            {
                var result = todorepository.GetToDoById(id).Result;
                return result != null;
            }).WithMessage("Todo not found");
        }
    }
}
