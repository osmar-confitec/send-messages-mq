using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
  public  class PostAuthorizationsTransfersIntegration : IntegrationEvent
    {
        public string cnpjEstabelecimentoDestino { get; set; }

        public string cpfOperadorResponsavel { get; set; }

        public string MulticastNotSupportedException { get; set; }

        public string placaVeiculo { get; set; }

        public decimal valorVenda { get; set; }
    }
}
