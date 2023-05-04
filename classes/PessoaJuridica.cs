using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforco_backend.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ {get; set;}

        public void Inserir(PessoaJuridica pj)
        {
            using (StreamWriter sw = new StreamWriter(pj.Nome + ".txt"))
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.CNPJ}");
            }
        }

        public PessoaJuridica Ler(string nomePj)
        {
            PessoaJuridica pj = new PessoaJuridica();

            using (StreamReader sr = new StreamReader(nomePj + ".txt"))
            {
                string[] atributos = sr.ReadLine()!.Split(',');

                pj.Nome = atributos[0];
                pj.Rendimento = float.Parse(atributos[1]);
                pj.CNPJ = atributos[2];
            }

            return pj;
        }
    }
}