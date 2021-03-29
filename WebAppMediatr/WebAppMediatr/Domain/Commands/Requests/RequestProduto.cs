using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMediatr.Domain.Commands.Responses;

namespace WebAppMediatr.Domain.Commands.Requests
{
    //Existe um handle para cada request, que será encontrado com base nos parâmetros
    //Haverá um handle que retorne Um ResponseProduto e que recebe um RequestProduto
    public class RequestProduto: IRequest<ResponseProduto>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
