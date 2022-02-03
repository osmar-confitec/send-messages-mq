using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
   public class GetCRLVElectronicIntegrationResponse
    {

        public string AssinaturaDetranP7sBase64 { get; set; }

        public string CnpjEstabelecimento { get; set; }

        public DateTime DataEmissao { get; set; }

        public string HashPdfSha512 { get; set; }

        public string NomeEstabelecimento { get; set; }

        public string Numero { get; set; }

        public string PdfBase64 { get; set; }

        public string PdfCodigoSegurancaCrvBase64 { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

    }
}
