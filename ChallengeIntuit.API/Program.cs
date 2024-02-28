using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => 
options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.MapGet("/Clientes", () =>
{
    var dal = new DAL<Clientes>(new ChallengeIntuitContext());
    return Results.Ok(dal.Listar());
});

app.MapGet("/Clientes/{id}", (int id) =>
{
    var dal = new DAL<Clientes>(new ChallengeIntuitContext());
    var cliente = dal.ListarPor(a => a.Id.Equals(id));
    if(cliente == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(cliente);
});

app.MapPost("/Clientes", ([FromBody]Clientes clientes) =>
{
    var dal = new DAL<Clientes>(new ChallengeIntuitContext());
    dal.Adicionar(clientes);
    return Results.Ok();
});

app.Run();
