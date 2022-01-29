using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class GetStockVehicleFitnessIntegration : IntegrationEvent
    {

        public string numeroCrv { get; set; }

        public string placa { get; set; }

        public string renavam { get; set; }

        public string tipoCrv { get; set; }

    }
}
