using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public enum TipoDocumentoProprietarioAtual
    {
        CPF, CNPJ
    }
    public class VeiculoEntradaEstoque
    {
        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public string DocumentoProprietarioAtual { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

        public  TipoCrv TipoCrv { get; set; }

        public TipoDocumentoProprietarioAtual tipoDocumentoProprietarioAtual { get; set; }

    }
    public class PersistirSolicitacoesEntradaVeiculoEstoqueRequest
    {

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataCompra { get; set; }

        public string EmailEstabelecimento { get; set; }

        public string EmailVendedor { get; set; }

        public decimal ValorCompra { get; set; }

        public VeiculoEntradaEstoque Veiculo { get; set; }
    }
}
