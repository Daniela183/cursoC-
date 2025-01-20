using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class Quadrado : Forma
    {
        private double Lado { get; set; }
        public Quadrado(double lado)
        {
            Lado = lado;
        }
        public override double Area()
        {
            return (Lado * Lado);
        }
    }

}
