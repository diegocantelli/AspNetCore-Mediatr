using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMediatr.Domain.Commands.Responses
{
    //Este é o tipo que será retornado ao executar o send do mediatr 
    public class ResponseProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Date { get; set; }
    }
}
