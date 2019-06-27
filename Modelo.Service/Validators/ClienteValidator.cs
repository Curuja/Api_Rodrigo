using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto inexistente.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("CPF é obrigatório.")
                .NotNull().WithMessage("CPF é obrigatório.")
                .MaximumLength(11).WithMessage("CPF deve conter 11 caracteres sem pontos ou traços.");
                

            RuleFor(c => c.idade)
                    .NotEmpty().WithMessage("Idade é obrigatório.")
                    .NotNull().WithMessage("Idade é obrigatório.");

            RuleFor(c => c.Nome)
                    .NotEmpty().WithMessage("Nome é obrigatório.")
                    .NotNull().WithMessage("Nome é obrigatório.")
                     .MaximumLength(30).WithMessage("Nome deve conter 30 caracteres.");
        }
    }
}
