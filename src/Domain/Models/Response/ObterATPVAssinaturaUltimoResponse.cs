using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public enum TipoAssinaturaVendedor
    {
        PROPRIO_PUNHO_ATPV_PAPEL_MOEDA, PROPRIO_PUNHO_ATPVE, QUALIFICADA_P7S_SOBRE_FOTO_ATPV_PAPEL_MOEDA, QUALIFICADA_P7S_SOBRE_XML_ATPVE, AVANCADA_SOBRE_PDF_ATPVE
    }
   public class ObterATPVAssinaturaUltimoResponse
    {
        public string AssinaturaQualificadaP7sFotoAtpvPapelMoedaVendedorBase64 { get; set; }

        public string AssinaturaQualificadaP7sXmlAtpveVendedorBase64 { get; set; }

        public string Chassi { get; set; }

        public string CodigoSegurancaCrv { get; set; }

        public DateTime DataHoraRegistro { get; set; }

        public DateTime DataHoraRegistroAssinaturaVendedor { get; set; }

        public string FotoAtpvPapelMoedaAssinadoDeProprioPunhoBase64 { get; set; }

        public string FotoAtpvPapelMoedaSemAssinaturaBase64 { get; set; }

        public string FotoAtpveAssinadoDeProprioPunhoBase64 { get; set; }

        public string NumeroAtpve { get; set; }

        public string NumeroDocumentoComprador { get; set; }

        public string NumeroDocumentoVendedor { get; set; }

        public string PdfAtpveComAssinaturasAvancadasEmbarcadasBase64 { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public TipoAssinaturaVendedor TipoAssinaturaVendedor { get; set; }

        public string XmlAtpveBase64 { get; set; }


    }
}
