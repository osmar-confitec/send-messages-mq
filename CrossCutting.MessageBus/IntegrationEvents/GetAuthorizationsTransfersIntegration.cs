﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.MessageBus.IntegrationEvents
{
   public class GetAuthorizationsTransfersIntegration: IntegrationEvent
    {

        public string Chassi { get; set; }

        public string EstadoAutorizacao { get; set; }

        public string Placa { get; set; }

    }
}
