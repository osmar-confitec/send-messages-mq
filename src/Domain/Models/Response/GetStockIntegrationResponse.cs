using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{

    public class BuyerOutputStock
    {

        public Address Endereco { get; set; }

        public string Nome { get; set; }

        public string NumeroDocumento { get; set; }

        public TypeDocument TipoDocumento { get; set; }

    }
    public class CancellationExitStock
    {

        public DateTime DataHoraCancelamentoSaidaEstoque { get; set; }

        public Int64 IdEstoqueGeradoNoCancelamentoSaida { get; set; }
    }

    public enum Reason
    {
        VENDA, BAIXA_DO_VEICULO, TRANSFERENCIA_ESTABELECIMENTO, TRANSFERENCIA_FILIAIS, CANCELAMENTO_ENTRADA, DEVOLUCAO_MONTADORA
    }
    public class OutputStock
    {

        public CancellationExitStock CancelamentoSaidaEstoque { get; set; }

        public BuyerOutputStock Comprador { get; set; }

        public string ChaveNotaFiscalSaida { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraEnvioNotaFiscalSaida { get; set; }
        public Reason Motivo { get; set; }

        public Int64 NumeroTermoSaidaEstoque { get; set; }


    }
    public class VehicleRestriction
    {

        public string CodigoTipoRestricao { get; set; }

        public string TipoRestricao { get; set; }

    }
    public enum TypeDocument
    {

        CPF, CNPJ
    }
    public class SellerEntryStock
    {
        public string NumeroDocumento { get; set; }

        public TypeDocument TipoDocumento { get; set; }

    }
    public enum ReasonCancellationStock
    {
        DESISTENCIA, DEVOLUCAO_MONTADORA_FINS_DE_TRANSFORMACAO, DEVOLUCAO_MONTADORA_CORRECAO_DE_DADOS_CADASTRAIS_FABRIS, DEVOLUCAO_MONTADORA_AVARIAS, DEVOLUCAO_MONTADORA_VENDA_DIRETA

    }
    public class CancellationStock
    {

        public DateTime DataHoraCancelamentoEstoque { get; set; }

        public ReasonCancellationStock MotivoCancelamentoEstoque { get; set; }


    }
    public enum typeCrv
    {
        AZUL, VERDE, BRANCO, DIGITAL

    }
    public enum State
    {
        SOLICITADO, TRANSFERIDO, CONFIRMADO, FINALIZADO

    }
    public class OriginByCancellationStock
    {

        public Int64 IdEstoqueOrigem { get; set; }

    }
    public class InputStock
    {

        public string ChaveNotaFiscalEntrada { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraEnvioNotaFiscalEntrada { get; set; }

        public Int64 NumeroTermoEntradaEstoque { get; set; }

        public SellerEntryStock Vendedor { get; set; }


    }
   public class GetStockIntegrationResponse
    {
        public string Chassi { get; set; }

        public CancellationStock CancelamentoEstoque { get; set; }

        public InputStock EntradaEstoque { get; set; }
        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public State State { get; set; }

        public Int64 Id { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public OriginByCancellationStock OrigemPorCancelamentoEstoque { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

        public typeCrv TipoCrv { get; set; }

        public IEnumerable<VehicleRestriction> RestricoesVeiculo { get; set; }

        public OutputStock SaidaEstoque { get; set; }


        public GetStockIntegrationResponse()
        {

            RestricoesVeiculo = new List<VehicleRestriction>();


        }



    }
}
