using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class PostCancellationTransferAuthorizationsIntegration:IntegrationEvent
    {
        public string CnpjEstabelecimentoDestino { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public string EmailEstabelecimentoOrigem { get; set; }

        public string PlacaVeiculo { get; set; }

        public decimal ValorVenda { get; set; }
    }
}
