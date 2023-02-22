using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface IServico
    {
        void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
    }
}