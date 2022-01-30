using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class PostZeroVehicleStockInventoryCancellationsIntegration:IntegrationEvent
    {

        public string CpfOperadorResponsavel { get; set; }

        public string DataCancelamentoEntradaEstoque { get; set; }

        public int IdEstoque { get; set; }
    }
}
