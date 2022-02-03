using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
   public class PostCancellationTransferAuthorizationsIntegrationResponse
    {
        public string Chassi { get; set; }

        public string CnpjEstabelecimentoAutorizador { get; set; }

        public string CnpjEstabelecimentoDestino { get; set; }

        public string CpfOperadorResponsavelAutorizacao { get; set; }

        public DateTime DataHoraAutorizacao { get; set; }

        public EstadoAutorizacaoTransferencia EstadoAutorizacaoTransferencia { get; set; }


    }
}
