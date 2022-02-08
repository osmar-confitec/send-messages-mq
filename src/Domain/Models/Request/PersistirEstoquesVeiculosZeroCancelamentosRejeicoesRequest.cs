using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroCancelamentosRejeicoesRequest
    {

        public string CpfOperadorResponsavel { get; set; }
        public string Chassi  { get; set; }
    }
}
