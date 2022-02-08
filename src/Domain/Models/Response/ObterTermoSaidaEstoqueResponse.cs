using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class ObterTermoSaidaEstoqueResponse
    {

        public Int64 NumeroTermoSaidaEstoque { get; set; }

        public string PdfBase64 { get; set; }
    }
}
