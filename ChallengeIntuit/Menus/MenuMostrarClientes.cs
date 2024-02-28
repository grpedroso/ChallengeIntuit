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
        public override void Executar(Dictionary<string, Clientes> clientesRegistrados)
        {
            base.Executar(clientesRegistrados);
            MostrarTituloOpcion("Clientes en nuestra base de datos");

            foreach(var clientekvp in clientesRegistrados)
            {
                Clientes cliente = clientekvp.Value;
                Console.WriteLine($"Cliente: {cliente}");
            }
            Console.WriteLine("\nIngrese una tecla para volver al menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
