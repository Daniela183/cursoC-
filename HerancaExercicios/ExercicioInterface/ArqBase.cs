using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public abstract class ArqBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo: ");
        }
    }
}
