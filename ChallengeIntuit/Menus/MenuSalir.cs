using ChallengeIntuit.Banco;
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
        public override void Executar(DAL<Clientes> clienteDAL)
        {
            Console.WriteLine("Gracias por utlizar el sistema de Gabriel R Pedroso");
        }

    }
}
