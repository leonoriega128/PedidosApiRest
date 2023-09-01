using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.CreateCourseCommand
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseValidator() 
        {
            RuleFor(p => p.CourseCode)
                      .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                       .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Commission)
                   .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
            RuleFor(p => p.State)
                 .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
