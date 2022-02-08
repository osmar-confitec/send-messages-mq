using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public enum MotivoRejeicao
    {
        DESISTENCIA, ERRO_OPERACIONAL_MONTADORA

    }
    public class PersistirEstoquesVeiculosZeroRejeicoesRequest
    {

        public string Chassi { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public MotivoRejeicao MotivoRejeicao { get; set; }

    }
}
