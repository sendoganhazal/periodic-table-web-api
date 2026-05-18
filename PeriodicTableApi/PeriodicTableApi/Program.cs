using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen ( );
builder.Services.AddDbContext<RepositoryContext> ( options =>
    options.UseSqlite ( builder.Configuration.GetConnectionString ( "DefaultConnection" ) )
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment ( ) )
{
    app.UseSwagger ( );
    app.UseSwaggerUI ( );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
