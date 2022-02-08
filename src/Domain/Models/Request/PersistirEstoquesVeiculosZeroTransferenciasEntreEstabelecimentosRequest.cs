using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class PersistirEstoquesVeiculosZeroTransferenciasEntreEstabelecimentosRequest
    {

        public string ChaveNotaFiscal { get; set; }

        public string CpfOperadorResponsavel { get; set; }

        public DateTime DataHoraMedicaoHodometro { get; set; }

        public DateTime DataTransferenciaEstoque { get; set; }

        public Int64 IdAutorizacao { get; set; }

        public int QuilometragemHodometro { get; set; }

        public decimal ValorCompra { get; set; }


    }
}
