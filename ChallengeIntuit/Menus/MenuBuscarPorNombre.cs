using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Menus
{
    internal class MenuBuscarPorNombre : Menu
    {
        public override void Executar(Dictionary<string, Clientes> clientesRegistrados)
        {
            base.Executar(clientesRegistrados);
            MostrarTituloOpcion("Mostrar detalles del cliente");
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            if(clientesRegistrados.ContainsKey(nombreCliente))
            {
                Clientes clientes = clientesRegistrados[nombreCliente];
                Console.Write(clientes);
                Console.WriteLine("\nIngrese una tecla para volver al menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado en la base de datos");
                Console.WriteLine("\nIngrese una tecla para volver al menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
