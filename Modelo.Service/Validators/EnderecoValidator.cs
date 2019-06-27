using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto inexistente.");
                });

            RuleFor(c => c.logradouro)
                .NotEmpty().WithMessage("Logradouro é obrigatório.")
                .NotNull().WithMessage("Logradouro é obrigatório..")
                .MaximumLength(50).WithMessage("Maximo de 50 caracteres");

            RuleFor(c => c.Bairro)
                    .NotEmpty().WithMessage("Bairro é obrigatório..")
                    .NotNull().WithMessage("Bairro é obrigatório.")
                    .MaximumLength(50).WithMessage("Maximo de 40 caracteres"); ;

            RuleFor(c => c.Cidade)
                    .NotEmpty().WithMessage("Cidade é obrigatório.")
                    .NotNull().WithMessage("Cidade é obrigatório.")
                    .MaximumLength(40).WithMessage("Maximo de 40 caracteres"); ;

            RuleFor(c => c.Estado)
                  .NotEmpty().WithMessage("Estado é obrigatório.")
                  .NotNull().WithMessage("Estado é obrigatório.")
                  .MaximumLength(40).WithMessage("Maximo de 40 caracteres"); ;
        }
    }
}
