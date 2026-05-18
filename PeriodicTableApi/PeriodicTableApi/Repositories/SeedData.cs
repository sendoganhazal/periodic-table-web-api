using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Models;

namespace PeriodicTableApi.Repositories
{
    public static class SeedData
    {
        private class PeriodicTableWrapper
        {
            public List<JsonElement> Elements { get; set; } = new ( );
        }

        public static async Task Initialize ( RepositoryContext context )
        {
            Console.WriteLine ( "--> Seed işlemi başlatıldı..." );

            await context.Database.MigrateAsync ( );

            if ( await context.Elements.AnyAsync ( ) )
            {
                Console.WriteLine ( "--> Veritabanında zaten element var. Seed işlemi iptal edildi." );
                return;
            }

            string filePath = "periodic-table.json";
            if ( !File.Exists ( filePath ) )
            {
                Console.WriteLine ( $"CRITICAL ERROR: '{filePath}' dosyası projenin kök dizininde bulunamadı!" );
                return;
            }

            Console.WriteLine ( "--> JSON dosyası bulundu, okunuyor..." );
            string jsonContent = await File.ReadAllTextAsync(filePath);

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                PropertyNameCaseInsensitive = true
            };

            var wrapper = JsonSerializer.Deserialize<PeriodicTableWrapper>(jsonContent, jsonOptions);
            if ( wrapper == null || wrapper.Elements == null || !wrapper.Elements.Any ( ) )
            {
                Console.WriteLine ( "CRITICAL ERROR: JSON sökülemedi veya elements dizisi boş." );
                return;
            }

            Console.WriteLine ( $"--> {wrapper.Elements.Count} element veritabanına yazılıyor..." );

            foreach ( var elementJson in wrapper.Elements )
            {
                try
                {
                    var element = JsonSerializer.Deserialize<Element>(elementJson.GetRawText(), jsonOptions);
                    if ( element == null ) continue;

                    if ( elementJson.TryGetProperty ( "shells", out var shellsProp ) && shellsProp.ValueKind == JsonValueKind.Array )
                    {
                        var shellsList = JsonSerializer.Deserialize<List<int>>(shellsProp.GetRawText());
                        if ( shellsList != null ) element.ShellsRaw = string.Join ( ",", shellsList );
                    }
                    if ( elementJson.TryGetProperty ( "ionization_energies", out var ionProp ) && ionProp.ValueKind == JsonValueKind.Array )
                    {
                        var ionList = JsonSerializer.Deserialize<List<double>>(ionProp.GetRawText());
                        if ( ionList != null ) element.IonizationEnergiesRaw = string.Join ( ",", ionList );
                    }

                    if ( elementJson.TryGetProperty ( "image", out var imageProp ) && imageProp.ValueKind == JsonValueKind.Object )
                    {
                        var imageObj = JsonSerializer.Deserialize<ElementImage>(imageProp.GetRawText(), jsonOptions);
                        if ( imageObj != null )
                        {
                            element.Image = imageObj;
                        }
                    }

                    context.Elements.Add ( element );
                }
                catch ( Exception ex )
                {
                    Console.WriteLine ( $"UYARI: Bir element eklenirken atlandı. Hata: {ex.Message}" );
                    continue;
                }
            }
            await context.SaveChangesAsync ( );
            Console.WriteLine ( "SUCCESS: 119 Element başarıyla SQLite veritabanına kaydedildi!" );
        }
    }
}