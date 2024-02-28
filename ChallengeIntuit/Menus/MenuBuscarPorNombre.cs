using ChallengeIntuit.Banco;
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
        public override void Executar(DAL<Clientes> clienteDAL)
        {
            base.Executar(clienteDAL);
            MostrarTituloOpcion("Mostrar detalles del cliente");
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            var clienteRecuperado = clienteDAL.RecuperarPor(a => a.Nombre.Equals(nombreCliente));
            if(clienteRecuperado is not null )
            {
                Console.Write(clienteRecuperado);
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
