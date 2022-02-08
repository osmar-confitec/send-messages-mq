using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public enum Evento
    {
        COMPRA, VENDA

    }
    public class PersistirNotasFiscaisRequest
    {
        public string ChaveNotaFiscal { get; set; }
        public Evento Evento { get; set; }

        public Int64 IdEstoque { get; set; }


    }
}
