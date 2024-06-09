using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoWebAPI.Application.ToDos.Commands.CreateToDo
{
    public class CreateToDoCommandValidator : AbstractValidator<CreateToDoCommand>
    {
        public CreateToDoCommandValidator()
        {
            
            RuleFor(v => v.Name).NotEmpty().WithMessage("Name is required");

            
        }
        
    }
}
