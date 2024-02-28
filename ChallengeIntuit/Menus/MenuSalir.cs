using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Menus
{
    internal class MenuSalir: Menu
    {
        public override void Executar(Dictionary<string, Clientes> clientesRegistrados)
        {
            Console.WriteLine("Gracias por utlizar el sistema de Gabriel R Pedroso");
        }

    }
}
