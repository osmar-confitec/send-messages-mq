using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class GetStockVehicleFitnessIntegration : IntegrationEvent
    {

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public string TipoCrv { get; set; }

    }
}
