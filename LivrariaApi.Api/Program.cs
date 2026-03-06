using Microsoft.EntityFrameworkCore;
using LivrariaApi.Api.Models; // Importa o seu toDoContext e Products

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------
// 1. CONFIGURAÇÃO DE SERVIÇOS (O antigo ConfigureServices)
// ---------------------------------------------------

// Diz para a API usar o padrão de Controladores em vez de Minimal APIs
builder.Services.AddControllers();

// Registra o Banco de Dados em Memória
builder.Services.AddDbContext<toDoContext>(opt =>
    opt.UseInMemoryDatabase("LivrariaDB"));

// Configura o Swagger (interface visual de testes)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ---------------------------------------------------
// 2. CONFIGURAÇÃO DO PIPELINE (O antigo Configure)
// ---------------------------------------------------

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// ESSENCIAL: Diz para a API procurar os [Route] que estão dentro dos seus Controladores
app.MapControllers();

app.Run();