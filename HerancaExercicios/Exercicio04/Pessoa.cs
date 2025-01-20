using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public override string ToString()
        {
            return "Olá! Meu nome é: " + Nome;
        }
    }
}
