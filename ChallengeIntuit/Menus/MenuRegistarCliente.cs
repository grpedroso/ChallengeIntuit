using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Menus
{
    internal class MenuRegistarCliente : Menu
    {
        public override void Executar(DAL<Clientes> clienteDAL)
        {
            base.Executar(clienteDAL);
            MostrarTituloOpcion("Registro de clientes");
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreC = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ");
            string apellidoC = Console.ReadLine();
            Console.Write("Ingrese la fecha de nacimineto del cliente (yyyy-MM-dd): ");
            DateTime fechaC = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el CUIT del cliente: ");
            string cuitC = Console.ReadLine();
            Console.Write("Ingrese el domicilio del cliente: ");
            string domicilioC = Console.ReadLine();
            Console.Write("Ingrese el telefono del cliente: ");
            string telefonoC = Console.ReadLine();
            Console.Write("Ingrese el email del cliente: ");
            string emailC = Console.ReadLine();

            Clientes cliente = new Clientes(nombreC, apellidoC, fechaC, cuitC, domicilioC, telefonoC, emailC);
            clienteDAL.Adicionar(cliente);
            Console.WriteLine($"El cliente {nombreC} fue registrado correctamente");
            Thread.Sleep(4000);
            Console.Clear();

        }
    }
}
