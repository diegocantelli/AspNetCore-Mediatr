using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMediatr.Domain.Commands.Requests;
using WebAppMediatr.Domain.Commands.Responses;

namespace WebAppMediatr.Domain.Handlers
{
    public interface ICadastroProdutoHandler
    {
        ResponseProduto Handle(RequestProduto requestProduto);
    }
}
