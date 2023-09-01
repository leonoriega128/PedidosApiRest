using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.CreateContractCommand
{
    public class CreateContractCommandValidator : AbstractValidator<CreateContractCommand>
    {
        public CreateContractCommandValidator()
        {
            RuleFor(p => p.CreatedBy)
                   .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                    .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.ContractId)
                   .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
            RuleFor(p => p.ItemId)
                 .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
