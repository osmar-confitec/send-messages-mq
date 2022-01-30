using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
  public class GetStockIntegration:IntegrationEvent
    {

        public string Chassi { get; set; }

        public string EstadoEstoque { get; set; }

        public string Placa { get; set; }

    }
}
