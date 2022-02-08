using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroEntradasEstoqueRequest
    {
        public string Chassi { get; set; }

        public string ChaveNotaFiscal { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataEntradaEstoque { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public int QuilometragemHodometro { get; set; }

        public decimal valorCompra { get; set; }
    }
}
