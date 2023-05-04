using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforco_backend.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ {get; set;}
    }
}