using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using ChallengeIntuit.API.Endpoints;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChallengeIntuitContext>((options) =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ChallengeIntuitDB"]).UseLazyLoadingProxies();
});
builder.Services.AddTransient<DAL<Clientes>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => 
options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddCors();
var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();

});

app.AddEndPointsClientes();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
