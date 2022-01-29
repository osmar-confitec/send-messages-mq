using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class GetAuthorizationsTransfersIntegration: IntegrationEvent
    {

        public string chassi { get; set; }

        public string estadoAutorizacao { get; set; }

        public string placa { get; set; }

    }
}
