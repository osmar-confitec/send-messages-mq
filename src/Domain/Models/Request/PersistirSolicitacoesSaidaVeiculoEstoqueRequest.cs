using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class VeiculoSaidaEstoque
    {
        public string CodigoSegurancaCrv { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

       
    }
    public class PersistirSolicitacoesSaidaVeiculoEstoqueRequest
    {
        public CompradorSaidaEstoque Comprador { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataVenda { get; set; }

        public string EmailEstabelecimento { get; set; }

        public decimal ValorVenda { get; set; }

        public VeiculoSaidaEstoque VeiculoSaidaEstoque { get; set; }
    }
}
