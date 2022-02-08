using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class EnvioAssinaturaProprioPunhoAtpve
    {
        public string FotoAtpveAssinadoDeProprioPunhoBase64 { get; set; }

    }

    public class EnvioAssinaturaQualificadaP7sSobreFotoAtpvPapelMoeda
    {

        public string AssinaturaQualificadaP7sBase64 { get; set; }

        public string FotoAtpvPapelMoedaSemAssinaturaBase64 { get; set; }


    }

    public class EnvioAssinaturaQualificadaP7sSobreXmlAtpve
    {

        public string AssinaturaQualificadaP7sBase64 { get; set; }

    }

    public class EnvioAssinaturaProprioPunhoAtpvPapelMoeda
    {

        public string FotoAtpvPapelMoedaAssinadoBase64 { get; set; }


    }
   public class PersistirATPVAssinaturaVendedorRequest
    {
        public Int64 IdEstoque { get; set; }

        public EnvioAssinaturaProprioPunhoAtpvPapelMoeda EnvioAssinaturaProprioPunhoAtpvPapelMoeda { get; set; }

        public EnvioAssinaturaProprioPunhoAtpve EnvioAssinaturaProprioPunhoAtpve { get; set; }

        public EnvioAssinaturaQualificadaP7sSobreFotoAtpvPapelMoeda EnvioAssinaturaQualificadaP7sSobreFotoAtpvPapelMoeda { get; set; }

        public EnvioAssinaturaQualificadaP7sSobreXmlAtpve EnvioAssinaturaQualificadaP7sSobreXmlAtpve { get; set; }

    }
}
