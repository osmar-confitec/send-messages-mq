using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroSaidasEstoqueRequest
    {
        public string ChaveNotaFiscal { get; set; }

        public CompradorSaidaEstoque Comprador { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataVenda { get; set; }

        public string EmailEstabelecimento { get; set; }

        public Int64 IdEstoque { get; set; }

        public decimal ValorVenda { get; set; }


    }
}
