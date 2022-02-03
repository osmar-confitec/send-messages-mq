using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{

    public class Veiculo
    {
        public string Chassi { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public string UfJurisdicao { get; set; }

 
    }
    public class Boletos {

        public DateTime DataVencimentoBoleto { get; set; }

        public string NumeroCodigoBarras { get; set; }

        public decimal ValorBoleto { get; set; }

    }
    public class InformacoesDebitos
    {
        public IEnumerable<Boletos> Boletos { get; set; }

        public IEnumerable<string> CodigosBancos { get; set; }

        public bool ExistemDebitos { get; set; }

        public decimal ValorDebitoDpvat { get; set; }

        public decimal ValorDebitoIpva { get; set; }

        public decimal ValorDebitoLicenciamento { get; set; }

        public decimal ValorDebitoMultas { get; set; }

        public decimal ValorTaxasEDebitosDiversos { get; set; }

        public InformacoesDebitos()
        {
            Boletos = new List<Boletos>();
            CodigosBancos = new List<string>();
        }
    }
    public class Diagnostico
    {
        public IEnumerable<string> MotivosParaNaoAptidao { get; set; }

        public bool VeiculoApto { get; set; }

        public bool VeiculoBaixado { get; set; }

        public bool VeiculoComAlarme { get; set; }

        public bool VeiculoComLicenciamentoProvisorio { get; set; }

        public bool VeiculoComPendenciaDeEmissaoCrv { get; set; }

        public bool VeiculoComRecall { get; set; }

        public bool VeiculoComRestricaoImpeditivaNoDetran { get; set; }

        public bool VeiculoComRestricaoJudicial { get; set; }

        public bool VeiculoComRestricaoNaReceitaFederal { get; set; }

        public bool VeiculoComRestricaoPgfn { get; set; }

        public bool VeiculoComRouboFurto { get; set; }

        public bool VeiculoSemAtpv { get; set; }

        public bool VeiculoTemAutorizacaoTransferenciaParaEstabelecimentoDiferenteDoEstabelecimentoConsultante { get; set; }

        public bool VeiculoTemComunicacaoDeVendaParaCompradorDiferenteDoEstabelecimentoConsultante { get; set; }

        public bool VeiculoTemIntencaoDeVendaParaCompradorDiferenteDoEstabelecimentoConsultante { get; set; }

        public Diagnostico()
        {
            MotivosParaNaoAptidao = new List<string>();
        }

      }
    public class EstabelecimentoAutorizador
    {

        public string Cnpj { get; set; }

        public string Nome { get; set; }
    }
    public class AutorizacaoTransferencia
    {
        public string CpfOperadorResponsavelAutorizacao { get; set; }

        public DateTime DataHoraAutorizacao { get; set; }

        public EstabelecimentoAutorizador EstabelecimentoAutorizador { get; set; }


    }
    public  class GetStockVehicleFitnessIntegrationResponse
    {

        public AutorizacaoTransferencia AutorizacaoTransferencia { get; set; }

        public bool ComunicacaoComDetranFalhou { get; set; }

        public Diagnostico Diagnostico { get; set; }

        public InformacoesDebitos InformacoesDebitos { get; set; }

        public Veiculo Veiculo { get; set; }

    }
}
