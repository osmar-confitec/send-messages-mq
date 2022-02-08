using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public  class PersistirEstoquesVeiculosZeroAutorizacaoTransferenciasResponse
    {
        public string Chassi { get; set; }
        public string PlacaVeiculo { get; set; }

        public Int64 IdEstoque { get; set; }
        public Int64 Id { get; set; }

        public string CnpjEstabelecimentoAutorizador { get; set; }

        public string CnpjEstabelecimentoDestino { get; set; }

        public string CpfOperadorResponsavelAutorizacao { get; set; }

        public DateTime DataHoraAutorizacao { get; set; }

        public string EstadoAutorizacaoTransferencia { get; set; }


    }
}
