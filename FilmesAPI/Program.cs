//IDEIA DE RESPONDER OS CONTATOS DE FORMA AUTOMATICA COM A API DO CHAT GPT, DO WPP E 
//VER COM OÉ A API DO CHATGPT //Teste autor no git..

using FilmesAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("FilmeConnection");
//FilmeContext = classe de cotexto para acesso ao banco
builder.Services.AddDbContext<FilmeContext>(opts => 
                              opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
//AutoMapper - Dtos conversão
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
