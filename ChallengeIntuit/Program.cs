using ChallengeIntuit.Banco;
using ChallengeIntuit.Menus;
using ChallengeIntuit.Modelos;

var clienteDAL = new DAL<Clientes>();


Dictionary<string, Clientes> clientesRegistrados = new();


Dictionary<int, Menu> opciones = new();
opciones.Add(1, new MenuRegistarCliente());
opciones.Add(2, new MenuMostrarClientes());
opciones.Add(3, new MenuBuscarPorNombre());
opciones.Add(-1, new MenuSalir());

void ExibirImagen()
{
    Console.WriteLine(@"

        ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
        █▄▄░▄▄█░▄▄▀█░▄▄▀█░██░▄▄▀████░▄▄▀██░████▄░▄██░▄▄▄██░▀██░█▄▄░▄▄██░▄▄▄██░▄▄▄░
        ███░███░▀▀░█░▄▄▀█░██░▀▀░████░█████░█████░███░▄▄▄██░█░█░███░████░▄▄▄██▄▄▄▀▀
        ███░███▄██▄█▄▄▄▄█▄▄█▄██▄████░▀▀▄██░▀▀░█▀░▀██░▀▀▀██░██▄░███░████░▀▀▀██░▀▀▀░
        ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

    ");
    Console.WriteLine("Bienvenido al sistema de registro de clientes!");
}

void ExibirOpcionesDelMenu()
{
    ExibirImagen();
    Console.WriteLine("\nIngrese 1 para registrar un cliente");
    Console.WriteLine("Ingrese 2 para mostrar todos los clientes");
    Console.WriteLine("Ingrese 3 para buscar un cliente especifico");
    Console.WriteLine("Ingrese -1 para salir");

    Console.Write("\nIngrese su opcion: ");
    int opcaoSeleccionada = int.Parse(Console.ReadLine()!);
 

    if (opciones.ContainsKey(opcaoSeleccionada))
    {
        Menu menuASerExibido = opciones[opcaoSeleccionada];
        menuASerExibido.Executar(clienteDAL);
        if (opcaoSeleccionada > 0) ExibirOpcionesDelMenu();
    }
    else
    {
        Console.WriteLine("Opcion incorrecta");
    }
}

ExibirOpcionesDelMenu();