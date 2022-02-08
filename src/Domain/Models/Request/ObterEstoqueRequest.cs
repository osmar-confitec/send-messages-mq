using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class ObterEstoqueRequest
    {
        public string Chassi { get; set; }

        public string EstadoEstoque { get; set; }

        public string Placa { get; set; }
    }
}
