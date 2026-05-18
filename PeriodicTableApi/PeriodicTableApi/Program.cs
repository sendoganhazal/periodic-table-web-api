using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers ( );
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

app.UseHttpsRedirection ( );

app.UseAuthorization ( );

app.MapControllers ( );

using ( var scope = app.Services.CreateScope ( ) )
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<RepositoryContext>();
       
        await SeedData.Initialize ( context );
    }
    catch ( Exception ex )
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError ( ex, "Veritabanýna veri beslemesi yapýlýrken bir hata oluþtu." );

 
        Console.WriteLine ( "==================================================" );
        Console.WriteLine ( $"CRITICAL SEED ERROR: {ex.Message}" );
        if ( ex.InnerException != null )
        {
            Console.WriteLine ( $"INNER EXCEPTION: {ex.InnerException.Message}" );
        }
        Console.WriteLine ( $"STACK TRACE: {ex.StackTrace}" );
        Console.WriteLine ( "==================================================" );
    }
}

app.Run ( );
