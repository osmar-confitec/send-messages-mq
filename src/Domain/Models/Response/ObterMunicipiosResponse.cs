using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public class ObterMunicipiosResponse
    {

        public string Id { get; set; }

        public string Nome { get; set; }

        public Uf Uf { get; set; }
    }
}
