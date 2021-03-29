using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAppMediatr.Domain.Commands.Requests;
using WebAppMediatr.Domain.Commands.Responses;

namespace WebAppMediatr.Domain.Handlers
{
    public class CadastroProdutoHandler : IRequestHandler<RequestProduto, ResponseProduto>
    {
        //Este é o método que será acionado quando um parâmetro do tipo RequestProduto e que devolve um ResponseProduto for acionado pelo
        // mediatr
        public Task<ResponseProduto> Handle(RequestProduto request, CancellationToken cancellationToken)
        {
            var resultado = new ResponseProduto
            {
                Id = Guid.NewGuid(),
                Nome = "Iphone X",
                Valor = 4000,
                Date = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
