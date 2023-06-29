using Microsoft.OpenApi.Models;
using STgenetics.Farm.Application;
using STgenetics.Farm.Infrastructure;
using STgenetics.Farm.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {        
        Title = "STgenetics Farm API",
        Description = "API for farm management for the technical challenge for STgenetics",
        Contact = new OpenApiContact
        {
            Name = "Julian Camilo Cortes Chia",
            Email = "julianccortes@gmail.com"
        }
    });
});

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));


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

app.UseHttpsRedirection();
app.UseRouting();
app.UseErrorHandlingMiddleware();
app.UseCors("corsapp");
app.Run();
