using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public  class PersistirEstoquesVeiculosZeroCancelamentosEntradaEstoqueRequest
    {

        public string CpfOperadorResponsavel { get; set; }

        public int DataCancelamentoEntradaEstoque { get; set; }
        
        public Int64 IdEstoque { get; set; }
        
    }
}
