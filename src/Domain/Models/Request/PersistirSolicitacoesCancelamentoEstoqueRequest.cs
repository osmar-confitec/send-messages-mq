using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{

    public class VeiculoCancelamentoEstoque {

        public string CodigoSegurancaCrv { get; set; }

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }



    }
    public class PersistirSolicitacoesCancelamentoEstoqueRequest
    {
        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataCancelamentoEstoque { get; set; }

        public VeiculoCancelamentoEstoque Veiculo { get; set; }

    }
}
