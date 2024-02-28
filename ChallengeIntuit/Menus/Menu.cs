using ChallengeIntuit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIntuit.Menus
{
    internal class Menu
    {
        public void MostrarTituloOpcion(string titulo)
        {
            int cantidadDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(cantidadDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(Dictionary<string, Clientes> clientesRegistrados)
        {
            Console.Clear();
        }

    }
}
