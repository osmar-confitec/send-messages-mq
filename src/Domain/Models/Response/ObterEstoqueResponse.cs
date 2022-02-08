using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class CompradorSaidaEstoque
    {

        public Endereco Endereco { get; set; }

        public string Nome { get; set; }

        public string NumeroDocumento { get; set; }

        public TypeDocument TipoDocumento { get; set; }

    }
    public class CancelamentoSaidaEstoque
    {

        public DateTime DataHoraCancelamentoSaidaEstoque { get; set; }

        public Int64 IdEstoqueGeradoNoCancelamentoSaida { get; set; }
    }

    public enum Reason
    {
        VENDA, BAIXA_DO_VEICULO, TRANSFERENCIA_ESTABELECIMENTO, TRANSFERENCIA_FILIAIS, CANCELAMENTO_ENTRADA, DEVOLUCAO_MONTADORA
    }
    public class SaidaEstoque
    {

        public CancelamentoSaidaEstoque CancelamentoSaidaEstoque { get; set; }

        public CompradorSaidaEstoque Comprador { get; set; }

        public string ChaveNotaFiscalSaida { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraEnvioNotaFiscalSaida { get; set; }
        public Reason Motivo { get; set; }

        public Int64 NumeroTermoSaidaEstoque { get; set; }


    }
    public class RestricoesVeiculo
    {

        public string CodigoTipoRestricao { get; set; }

        public string TipoRestricao { get; set; }

    }
    public enum TypeDocument
    {

        CPF, CNPJ
    }
    public class VendedorEntradaEstoque
    {
        public string NumeroDocumento { get; set; }

        public TypeDocument TipoDocumento { get; set; }

    }
    public enum MotivoDevolucaoMontadora
    {
        DESISTENCIA, DEVOLUCAO_MONTADORA_FINS_DE_TRANSFORMACAO, DEVOLUCAO_MONTADORA_CORRECAO_DE_DADOS_CADASTRAIS_FABRIS, DEVOLUCAO_MONTADORA_AVARIAS, DEVOLUCAO_MONTADORA_VENDA_DIRETA

    }
    public class CancelamentoEstoque
    {

        public DateTime DataHoraCancelamentoEstoque { get; set; }

        public MotivoDevolucaoMontadora MotivoCancelamentoEstoque { get; set; }


    }
    public enum TipoCrv
    {
        AZUL, VERDE, BRANCO, DIGITAL

    }
    public enum Estado
    {
        SOLICITADO, TRANSFERIDO, CONFIRMADO, FINALIZADO

    }
    public class OrigemPorCancelamentoEstoque
    {

        public Int64 IdEstoqueOrigem { get; set; }

    }
    public class EntradaEstoque
    {

        public string ChaveNotaFiscalEntrada { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataHora { get; set; }

        public DateTime DataHoraEnvioNotaFiscalEntrada { get; set; }

        public Int64 NumeroTermoEntradaEstoque { get; set; }

        public VendedorEntradaEstoque Vendedor { get; set; }


    }

    public class ObterEstoqueResponse
    {
        public string Chassi { get; set; }

        public CancelamentoEstoque CancelamentoEstoque { get; set; }

        public EntradaEstoque EntradaEstoque { get; set; }
        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public Estado State { get; set; }

        public Int64 Id { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public OrigemPorCancelamentoEstoque OrigemPorCancelamentoEstoque { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

        public TipoCrv TipoCrv { get; set; }

        public IEnumerable<RestricoesVeiculo> RestricoesVeiculo { get; set; }

        public SaidaEstoque SaidaEstoque { get; set; }


        public ObterEstoqueResponse()
        {

            RestricoesVeiculo = new List<RestricoesVeiculo>();


        }

    }
}
