using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class PostZeroVehicleStockAuthorizedTransferCancellationsIntegration:IntegrationEvent
    {
        public string CpfOperadorResponsavel { get; set; }

        public int IdAutorizacao { get; set; }
    }
}
