﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public  class GetCRLVElectronicIntegration : IntegrationEvent
    {
        public string PlacaVeiculo { get; set; }

        public string RenavamVeiculo { get; set; }
    }
}
