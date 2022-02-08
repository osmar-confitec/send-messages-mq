using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
  
    public class PersistirEstoquesVeiculosZeroDevolucoesMontadoraRequest
    {
        public string ChaveNotaFiscal { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataDevolucao { get; set; }

        public Int64 IdEstoque { get; set; }

        public MotivoDevolucaoMontadora MotivoDevolucaoMontadora { get; set; }
    }
}
