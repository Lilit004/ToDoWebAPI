using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoWebAPI.Application.ToDos.Commands.CreateToDo;

namespace ToDoWebAPI.Application.ToDos.Commands.UpdateToDo
{
    internal class UpdateToDoCommandValidator : AbstractValidator<CreateToDoCommand>
    {
        public UpdateToDoCommandValidator()
        {
            RuleFor(v => v.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
