using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class ObterTermoEntradaEstoqueResponse
    {

        public Int64 NumeroTermoEntradaEstoque { get; set; }

        public string PdfBase64 { get; set; }
    }
}
