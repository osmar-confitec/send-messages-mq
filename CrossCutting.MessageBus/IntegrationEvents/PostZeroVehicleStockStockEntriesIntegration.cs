using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class PostZeroVehicleStockStockEntriesIntegration:IntegrationEvent
    {

        public string Chassi { get; set; }

        public string ChaveNotaFiscal { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public string DataEntradaEstoque { get; set; }

        public DateTime? DataHoraMedicaoHodometro { get; set; }

        public int QuilometragemHodometro { get; set; }

        public decimal ValorCompra { get; set; }

    }
}
