using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class VeiculoEntradaEstoqueVeiculoProprio
    {
        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

        public TipoCrv TipoCrv { get; set; }

    }
    public class PersistirSolicitacoesEntradaVeiculoProprioEstoqueRequest
    {
        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataEntradaEstoque { get; set; }

        public VeiculoEntradaEstoqueVeiculoProprio Veiculo { get; set; }
    }
}
