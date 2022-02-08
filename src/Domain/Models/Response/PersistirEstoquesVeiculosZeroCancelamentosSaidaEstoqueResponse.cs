using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class PersistirEstoquesVeiculosZeroCancelamentosSaidaEstoqueResponse
    {
        public CancelamentoEstoque CancelamentoEstoque { get; set; }

        public string Chassi { get; set; }

        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public EntradaEstoque EntradaEstoque { get; set; }

        public Estado Estado { get; set; }

        public Int64 Id { get; set; }

        public string NumeroCrv { get; set; }

        public OrigemPorCancelamentoEstoque OrigemPorCancelamentoEstoque { get; set; }

        public string Placa { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

        public IEnumerable<RestricoesVeiculo> RestricoesVeiculo { get; set; }

        public SaidaEstoque SaidaEstoque { get; set; }

        public TipoCrv TipoCrv { get; set; }

        public PersistirEstoquesVeiculosZeroCancelamentosSaidaEstoqueResponse()
        {
            RestricoesVeiculo = new List<RestricoesVeiculo>();
        }
    }
}
