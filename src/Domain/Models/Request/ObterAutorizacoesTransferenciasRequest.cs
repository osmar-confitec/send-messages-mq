using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
   public class ObterAutorizacoesTransferenciasRequest
    {

        public string Chassi { get; set; }

        public string EstadoAutorizacao { get; set; }

        
        public string Placa { get; set; }

    }
}
