using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforco_backend.classes
{
    public abstract class PessoaJuridica
    {
        public string? Nome {get; set;}

        public float? Rendimento {get; set;}
    }
}