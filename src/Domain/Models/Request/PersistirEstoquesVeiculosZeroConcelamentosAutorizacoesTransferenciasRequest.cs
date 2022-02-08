using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroConcelamentosAutorizacoesTransferenciasRequest
    {

        public Int64 IdAutorizacao { get; set; }

        public string CpfOperadorResponsavel { get; set; }

    }
}
