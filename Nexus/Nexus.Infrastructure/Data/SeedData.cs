using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedResources(modelBuilder);
            SeedUniverse(modelBuilder);
        }


        private static void SeedResources(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(
                            new Resource { Id = 1, Code = "MINERALS", Name = "Minerals", Description = "Minerals extracted from the planetary crust. They are the most abundant resource and are mainly used for the creation of structures and ships." },
                            new Resource { Id = 2, Code = "MICROCHIPS", Name = "Microchips", Description = "Technological materials designed and created with high technology. They are used to a lesser extent than minerals." },
                            new Resource { Id = 3, Code = "HYDROGEN", Name = "Hydrogen", Description = "The main fuel for spaceships and is needed in smaller amounts by buildings and ships." },
                            new Resource { Id = 4, Code = "FOOD", Name = "Food", Description = "Represents the food supplies. They are necessary to keep the population alive." },
                            new Resource { Id = 5, Code = "POPULATION", Name = "Population", Description = "The number of inhabitants in each region." },
                            new Resource { Id = 6, Code = "CREDITS", Name = "Credits", Description = "The total money of the empire, obtained from trade treaties, taxes, and conquests. Credits are used to recruit troops, research, and close trade agreements." }
                        );
        }
        private static void SeedUniverse(ModelBuilder modelBuilder)
        {
            var solarSystems = new List<SolarSystem>();
            var planets = new List<Planet>();
            var regions = new List<Region>();
            var random = new Random();

            int planetIdCounter = 1;
            int regionIdCounter = 1;

            for (int i = 1; i <= 10; i++)
            {
                var solarSystem = new SolarSystem
                {
                    Id = i,
                    Name = $"Solar System {i}"
                };

                solarSystems.Add(solarSystem);

                int numberOfPlanets = random.Next(3, 10);
                for (int j = 1; j <= numberOfPlanets; j++)
                {
                    var planet = new Planet
                    {
                        Id = planetIdCounter++,
                        SolarSystemId = i
                    };

                    planets.Add(planet);

                    for (int k = 1; k <= 3; k++)
                    {
                        var region = new Region
                        {
                            Id = regionIdCounter++,
                            IsColonized = false,
                            PlanetId = planet.Id,
                            UserId = null
                        };

                        regions.Add(region);
                    }
                }
            }

            modelBuilder.Entity<SolarSystem>().HasData(solarSystems);
            modelBuilder.Entity<Planet>().HasData(planets);
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
