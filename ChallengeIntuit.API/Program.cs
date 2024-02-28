using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChallengeIntuitContext>();
builder.Services.AddTransient<DAL<Clientes>>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => 
options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.MapGet("/Clientes", ([FromServices]DAL<Clientes> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Clientes/{id}", ([FromServices]DAL < Clientes > dal, int id) =>
{
    var cliente = dal.ListarPor(a => a.Id.Equals(id));
    if(cliente == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(cliente);
});

app.MapPost("/Clientes", ([FromServices]DAL < Clientes > dal, [FromBody]Clientes clientes) =>
{
    dal.Adicionar(clientes);
    return Results.Ok();
});

app.MapDelete("/Clientes/{id}", ([FromServices] DAL<Clientes> dal, int id) =>
{
    var artista = dal.RecuperarPor(a =>a.Id.Equals(id));
    if(artista == null)
    {
        Results.NotFound();
    }
    dal.Borrar(artista);
    return Results.NoContent();
});

app.Run();
