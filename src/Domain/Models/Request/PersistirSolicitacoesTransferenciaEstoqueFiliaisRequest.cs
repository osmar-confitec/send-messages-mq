using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class VeiculoTransferencia
    {
        public DateTime DataHoraMedicaoHodometro { get; set; }

        public string Placa { get; set; }

        public int QuilometragemHodometro { get; set; }

        public string Renavam { get; set; }

    }
    public class PersistirSolicitacoesTransferenciaEstoqueFiliaisRequest
    {

        public string CnpjEstabelecimentoOrigemTransferencia { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataTransferenciaEstoque { get; set; }

        public string EmailEstabelecimentoSolicitante { get; set; }

        public VeiculoTransferencia Veiculo { get; set; }
    }
}
