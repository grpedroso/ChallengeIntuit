using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeIntuit.API.Endpoints
{
    public static class ClientesExtensions
    {
        public static void AddEndPointsClientes(this WebApplication app)
        {
            app.MapGet("/Clientes", ([FromServices] DAL<Clientes> dal) =>
            {
                return Results.Ok(dal.Listar());
            });

            app.MapGet("/Clientes/{id}", ([FromServices] DAL<Clientes> dal, int id) =>
            {
                var cliente = dal.ListarPor(a => a.Id.Equals(id));
                if (cliente == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(cliente);
            });
            app.MapGet("Clientes/BuscarPorNombre/{nombre}", ([FromServices] DAL<Clientes> dal, string nombre) =>
            {
                var cliente = dal.ListarPor(a => a.Nombre.Contains(nombre));
                if (cliente == null)
                {
                    Results.NotFound();
                }
                return Results.Ok(cliente);
            });

            app.MapPost("/Clientes", ([FromServices] DAL<Clientes> dal, [FromBody] Clientes clientes) =>
            {
                dal.Adicionar(clientes);
                return Results.Ok();
            });

            app.MapDelete("/Clientes/{id}", ([FromServices] DAL<Clientes> dal, int id) =>
            {
                var artista = dal.RecuperarPor(a => a.Id.Equals(id));
                if (artista == null)
                {
                    Results.NotFound();
                }
                dal.Borrar(artista);
                return Results.NoContent();
            });
            app.MapPut("/Clientes", ([FromServices] DAL<Clientes> dal, [FromBody] Clientes clientes) =>
            {
                var clienteUpdate = dal.RecuperarPor(a => a.Id == clientes.Id);
                if (clienteUpdate == null)
                {
                    Results.NotFound();
                }
                clienteUpdate.Nombre = clientes.Nombre;
                clienteUpdate.Apellidos = clientes.Apellidos;
                clienteUpdate.FechaNacimiento = clientes.FechaNacimiento;
                clienteUpdate.Cuit = clientes.Cuit;
                clienteUpdate.Domicilio = clientes.Domicilio;
                clienteUpdate.TelefonoCelular = clientes.TelefonoCelular;
                clienteUpdate.Email = clientes.Email;

                dal.Actualizar(clienteUpdate);

            });
        }
    }
}
