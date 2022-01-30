using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
  public class PostZeroVehicleStockVehicleManufacturerReturnsIntegration:IntegrationEvent
    {
        public string ChaveNotaFiscal { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public string DataDevolucao { get; set; }

        public int IdEstoque { get; set; }

        public string MotivoDevolucaoMontadora { get; set; }
    }
}
