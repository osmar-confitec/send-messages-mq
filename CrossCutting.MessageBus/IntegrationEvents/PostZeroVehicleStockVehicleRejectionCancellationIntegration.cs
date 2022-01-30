using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class PostZeroVehicleStockVehicleRejectionCancellationIntegration: IntegrationEvent
    {
        public string Chassi { get; set; }

        public string CpfOperadorResponsavel { get; set; }

    }
}
