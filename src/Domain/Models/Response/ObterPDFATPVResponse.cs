using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class ObterPDFATPVResponse
    {
        public string NumeroAtpv { get; set; }

        public string PdfAtpvBase64 { get; set; }

        public string XmlAtpvBase64 { get; set; }


    }
}
