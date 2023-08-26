using Microsoft.EntityFrameworkCore;
using tabela.fipe.busca.precos.Data;
using tabela.fipe.busca.precos.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inje��o de depend�ncia
builder.Services.AddDbContext<TabelaFipeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TabelaFipeConnectionString")));
builder.Services.AddScoped<IFipeService, FipeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
