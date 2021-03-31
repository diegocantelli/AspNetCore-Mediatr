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
    //A interface IRequest pode ser tipada ou não. Nos casos de querys, será tipada de acordo com o retorno da query
    //Nos casos de comandos, não é necessário ter um tipo de retorno associado, da mesma forma o Handle só terá o parâmetro de entrada
    // e não terá tipo de retorno
    //IRequest<ResponseProduto> -> ResnponseProduto é o que a query deve retornar
    //Implementar esta interface é importante, pois é através dela que o mediatr irá descobrir o handler associado a ela.
    public class RequestProduto: IRequest<ResponseProduto>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
