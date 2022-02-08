using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
   public class ObterAPTVSolicitacaoEntradaSaidaEstoqueVeiculoRequest
    {

        public string NumeroCrv { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public string TipoCrv { get; set; }


    }
}
