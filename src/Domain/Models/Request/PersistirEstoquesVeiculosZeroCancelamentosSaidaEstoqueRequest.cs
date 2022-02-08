using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroCancelamentosSaidaEstoqueRequest
    {
        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataCancelamentoSaidaEstoque { get; set; }

        public Int64 IdEstoque { get; set; }


    }
}
