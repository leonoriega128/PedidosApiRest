using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.CreateItemCommand
{
    public class CreateItemValidator :AbstractValidator<CreateDressItemCommand>
    {
        public CreateItemValidator() 
        {
            RuleFor(p => p.Name)
                         .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                          .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Price)
                   .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
