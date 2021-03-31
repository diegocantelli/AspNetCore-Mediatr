using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMediatr.Domain.Commands.Requests;

namespace WebAppMediatr.Validations
{
    public class ProdutoValidator: AbstractValidator<RequestProduto>
    {
        public ProdutoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty()
                .WithMessage("O nome não pode estar vazio");

            RuleFor(x => x.Valor).LessThan(0)
                .WithMessage("O Valor não pode ser negativo");
        }
    }
}
