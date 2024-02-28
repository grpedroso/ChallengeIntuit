using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Menus
{
    internal class MenuMostrarClientes : Menu
    {
        public override void Executar(DAL<Clientes> clienteDAL)
        {
            base.Executar(clienteDAL);
            MostrarTituloOpcion("Clientes en nuestra base de datos");

            foreach(var clientekvp in clienteDAL.Listar())
            {
                Console.WriteLine($"Cliente: {clientekvp}");
            }
            Console.WriteLine("\nIngrese una tecla para volver al menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
