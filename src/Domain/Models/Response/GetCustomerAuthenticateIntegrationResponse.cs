﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Response
{
    public enum Uf
    {
        AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SP, SC, SE, TO

    }
    public class County
    {
        public Uf Uf { get; set; }
        public string Id { get; set; }

        public string Nome { get; set; }



    }
    public class Address
    {
        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        public string Logradouro { get; set; }

        public County Municipio { get; set; }

        public string Numero { get; set; }

    }
   public class GetCustomerAuthenticateIntegrationResponse
    {
        public string Cnpj { get; set; }

        public string Nome { get; set; }

        public Address Endereco { get; set; }
    }
}
