using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using kingsmen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace kingsmen.DAL
{
    public static class Seeder
    {
        public static void SeedCharacters()
        {
            var services = new ServiceCollection();

            services.AddDbContext<CharacterContext>(optionsAction =>
            optionsAction.UseSqlite("Data Source=characters.db"));

            var providers = services.BuildServiceProvider();

            var context = providers.GetRequiredService<CharacterContext>();

            using (context)
            {
                context.Database.EnsureCreated();

                if (!context.Characters.Any())
                {
                    System.Console.WriteLine("Reading CSV file ...");

                    using (var reader = new StreamReader("Data/dc-wikia-data.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.MissingFieldFound = null;
                        csv.Configuration.RegisterClassMap<CharacterMap>();

                        var characters = csv.GetRecords<Character>();

                        System.Console.WriteLine("Finished reading CSV file");

                        System.Console.WriteLine("Seeding Database ...");

                        foreach (var item in characters)
                        {
                            context.Characters.AddAsync(item);
                        }
                    }

                    context.SaveChangesAsync();

                    System.Console.WriteLine("Finished Seeding Database");


                    System.Console.WriteLine("Reading CSV file 2 ...");

                    using (var reader = new StreamReader("Data/marvel-wikia-data.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.MissingFieldFound = null;
                        csv.Configuration.RegisterClassMap<CharacterMap>();

                        var characters = csv.GetRecords<Character>();

                        System.Console.WriteLine("Finished reading CSV file 2");

                        System.Console.WriteLine("Seeding Database ...");

                        foreach (var item in characters)
                        {
                            context.Characters.AddAsync(item);
                        }
                    }

                    context.SaveChangesAsync();

                    System.Console.WriteLine("Finished Seeding Database");


                }
            }
        }

        public sealed class CharacterMap : ClassMap<Character>
        {
            public CharacterMap()
            {
                AutoMap(CultureInfo.InvariantCulture);
                Map(m => m.Id).Ignore();
            }
        }


    }
}