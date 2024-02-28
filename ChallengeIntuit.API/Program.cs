using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using ChallengeIntuit.API.Endpoints;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChallengeIntuitContext>();
builder.Services.AddTransient<DAL<Clientes>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => 
options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.AddEndPointsClientes();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
