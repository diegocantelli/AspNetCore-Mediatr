using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMediatr.Domain.Commands.Requests;
using WebAppMediatr.Domain.Commands.Responses;

namespace WebAppMediatr.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public async Task<ResponseProduto> Cadastro([FromServices]IMediator mediator, [FromBody] RequestProduto requestProduto)
        {
            //O send irá enviar para o método handle que receba o tipo RequestProduto e retorne o tipo ResponseProduto
            return await mediator.Send(requestProduto);
        }
    }
}