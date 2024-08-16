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
            SeedDistrictsAndStructures(modelBuilder);
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
        private static void SeedDistrictsAndStructures(ModelBuilder modelBuilder)
        {
            // Identificadores para los distritos
            var civilDistrictId = 1;
            var industrialDistrictId = 2;

            // Agregar los distritos
            var districts = new List<District>
            {
                new District { Id = civilDistrictId, Name = "Civil District", Description = "Manages the population and administrative functions of the region." },
                new District { Id = industrialDistrictId, Name = "Industrial District", Description = "Handles the production of resources in the region." },
            };

            // Agregar las minas
            var mines = new List<Mine>
            {
                new Mine { Id = 1, Code = "MINERALS_MINE", GainMultiplier = 200, ResourceId = 1 },
                new Mine { Id = 2, Code = "MICROCHIPS_FACTORY", GainMultiplier = 200, ResourceId = 2 },
                new Mine { Id = 3, Code = "HYDROGEN_MINE", GainMultiplier = 135, ResourceId = 3 }
            };

            // Agregar las estructuras
            var structures = new List<Structure>
            {
                // Civil District Structures
                new Structure { Id = 5, Name = "Ayuntamiento", Description = "Central hub of the city where laws are enacted and the region is administered.", DistrictId = civilDistrictId },
                new Structure { Id = 6, Name = "Zona residencial", Description = "A network of hive buildings where the majority of your population lives.", DistrictId = civilDistrictId },
                new Structure { Id = 7, Name = "Sede de Hacienda", Description = "Bureaucrats work here to collect taxes from citizens.", DistrictId = civilDistrictId },
                new Structure { Id = 8, Name = "Centro médico", Description = "Protects citizens from disease and heals troops.", DistrictId = civilDistrictId },
                new Structure { Id = 9, Name = "Centro de medicina avanzada", Description = "Combines biotechnology and robotics to heal patients using nanobots.", DistrictId = civilDistrictId },
                new Structure { Id = 10, Name = "Sistema de alcantarillado", Description = "Facilitates drainage and improves regional sanitation.", DistrictId = civilDistrictId },

                // Industrial District Structures
                new Structure { Id = 1, Name = "Mina de Minerales", Description = "Extracts minerals from the planetary crust.", DistrictId = industrialDistrictId, MineId = 1 },
                new Structure { Id = 2, Name = "Fábrica de Microchips", Description = "Produces microchips necessary for advanced technology.", DistrictId = industrialDistrictId, MineId = 2 },
                new Structure { Id = 3, Name = "Mina de Hidrógeno", Description = "Extracts hydrogen, used as fuel for ships and energy.", DistrictId = industrialDistrictId, MineId = 3 },
                new Structure { Id = 4, Name = "Centro de gestión del trabajo", Description = "Improves work management in the mineral mine, increasing efficiency by 10%.", DistrictId = industrialDistrictId },
                new Structure { Id = 11, Name = "Departamento de I+D", Description = "Heavy industry minds work here to improve microchip production by 10%.", DistrictId = industrialDistrictId },
                new Structure { Id = 12, Name = "Red de tuberías de hidrógeno", Description = "Facilitates hydrogen processing, increasing extraction efficiency by 10%.", DistrictId = industrialDistrictId },
                new Structure { Id = 13, Name = "Reactor nuclear", Description = "Provides energy to the region. Each level adds more energy points.", DistrictId = industrialDistrictId },
                new Structure { Id = 14, Name = "Fábrica de autómatas", Description = "Modern assembly techniques and AI enable the construction of robots for work, increasing construction speed by 5%.", DistrictId = industrialDistrictId },
            };

            // Aplicar los datos semilla al modelBuilder
            modelBuilder.Entity<District>().HasData(districts);
            modelBuilder.Entity<Mine>().HasData(mines);
            modelBuilder.Entity<Structure>().HasData(structures);
        }

    }
}
