using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
     public  class PostZeroVehicleStockTransferAuthorization:IntegrationEvent
    {
        public string CnpjEstabelecimentoDestino { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public int IdEstoque { get; set; }

        public decimal valorVenda { get; set; }
    }
}
