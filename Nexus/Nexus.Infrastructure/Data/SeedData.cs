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
            SeedCards(modelBuilder);
            SeedArmy(modelBuilder);
        }


        private static void SeedResources(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(
                new Resource { Id = 1, Code = "MINERALS", Name = "Minerals", Description = "Minerals extracted from the planetary crust. They are the most abundant resource and are mainly used for the creation of structures and ships." },
                new Resource { Id = 2, Code = "MICROCHIPS", Name = "Microchips", Description = "Technological materials designed and created with high technology. They are used to a lesser extent than minerals." },
                new Resource { Id = 3, Code = "HYDROGEN", Name = "Hydrogen", Description = "The main fuel for spaceships and is needed in smaller amounts by buildings and ships." },
                new Resource { Id = 4, Code = "FOOD", Name = "Food", Description = "Represents the food supplies. They are necessary to keep the population alive." },
                new Resource { Id = 5, Code = "POPULATION", Name = "Population", Description = "The number of inhabitants in each region." },
                new Resource { Id = 6, Code = "CREDITS", Name = "Credits", Description = "The total money of the empire, obtained from trade treaties, taxes, and conquests. Credits are used to recruit troops, research, and close trade agreements." },
                new Resource { Id = 7, Code = "ENERGY", Name = "Energy", Description = "The total energy of the region. This energy powers all the region buildings." }
            );
        }
        private static void SeedUniverse(ModelBuilder modelBuilder)
        {
            var solarSystems = new List<SolarSystem>();
            var planets = new List<Planet>();
            var asteroidFields = new List<AsteroidField>();
            var jumpGates = new List<JumpGate>();
            var regions = new List<Region>();
            var random = new Random();

            int planetIdCounter = 1;
            int regionIdCounter = 1;

            // Crear nombres para los sistemas solares
            var solarSystemNames = new List<string>
            {
                "Alpha Centauri", "Betelgeuse", "Sirius", "Vega", "Rigel",
                "Orion", "Cassiopeia", "Draco", "Andromeda", "Taurus"
            };

            // Crear 10 sistemas solares
            for (int i = 1; i <= 10; i++)
            {
                int size = random.Next(0, 3) == 0 ? 7 : random.Next(0, 2) == 0 ? 9 : 11; // Tamaño del sistema solar (7x7, 9x9, o 11x11)
                var solarSystem = new SolarSystem
                {
                    Id = i,
                    Name = solarSystemNames[i - 1]
                };

                solarSystems.Add(solarSystem);

                var occupiedCoordinates = new HashSet<(int x, int y)>
                {
                    (size / 2, size / 2) // La estrella está siempre en el centro
                };

                // Crear planetas
                int maxPlanets = size - 2;
                int minPlanets = size - 5;
                int numberOfPlanets = random.Next(minPlanets, maxPlanets + 1);

                for (int j = 0; j < numberOfPlanets; j++)
                {
                    var planetCoordinates = GenerateValidCoordinates(size, occupiedCoordinates, random);
                    occupiedCoordinates.Add(planetCoordinates);
                    AddAdjacentCoordinates(planetCoordinates, occupiedCoordinates);

                    var planet = new Planet
                    {
                        Id = planetIdCounter++,
                        SolarSystemId = solarSystem.Id,
                        CoordinateX = planetCoordinates.x,
                        CoordinateY = planetCoordinates.y
                    };

                    planets.Add(planet);

                    // Crear regiones para cada planeta (3 regiones por planeta)
                    for (int k = 1; k <= 3; k++)
                    {
                        var region = new Region
                        {
                            Id = regionIdCounter++,
                            IsColonized = false,
                            PlanetId = planet.Id,
                            UserId = null,
                            UpdatedAt = DateTime.UtcNow,
                        };

                        regions.Add(region);
                    }
                }

                // Crear campos de asteroides (0-3)
                int numberOfAsteroidFields = random.Next(0, 4);
                for (int j = 0; j < numberOfAsteroidFields; j++)
                {
                    var asteroidCoordinates = GenerateValidCoordinates(size, occupiedCoordinates, random);
                    occupiedCoordinates.Add(asteroidCoordinates);

                    var asteroidField = new AsteroidField
                    {
                        Id = planetIdCounter++,
                        SolarSystemId = solarSystem.Id,
                        CoordinateX = asteroidCoordinates.x,
                        CoordinateY = asteroidCoordinates.y
                    };

                    asteroidFields.Add(asteroidField);
                }

                // Crear una puerta de salto
                var jumpGateCoordinates = GenerateValidCoordinates(size, occupiedCoordinates, random);
                occupiedCoordinates.Add(jumpGateCoordinates);

                var jumpGate = new JumpGate
                {
                    Id = i,
                    SolarSystemId = solarSystem.Id,
                    CoordinateX = jumpGateCoordinates.x,
                    CoordinateY = jumpGateCoordinates.y
                };

                jumpGates.Add(jumpGate);
            }

            modelBuilder.Entity<SolarSystem>().HasData(solarSystems);
            modelBuilder.Entity<Planet>().HasData(planets);
            modelBuilder.Entity<AsteroidField>().HasData(asteroidFields);
            modelBuilder.Entity<JumpGate>().HasData(jumpGates);
            modelBuilder.Entity<Region>().HasData(regions); // Agregar las regiones
        }

        // Función para generar coordenadas válidas para un planeta, campo de asteroides o puerta de salto
        private static (int x, int y) GenerateValidCoordinates(int size, HashSet<(int x, int y)> occupiedCoordinates, Random random)
        {
            int x, y;
            do
            {
                x = random.Next(1, size + 1);
                y = random.Next(1, size + 1);
            } while (occupiedCoordinates.Contains((x, y)));

            return (x, y);
        }

        // Función para marcar las coordenadas adyacentes como ocupadas
        private static void AddAdjacentCoordinates((int x, int y) coordinates, HashSet<(int x, int y)> occupiedCoordinates)
        {
            // Definimos los desplazamientos como una lista de tuplas
            (int x, int y)[] offsets =
            {
                (-1, -1), (-1, 0), (-1, 1),
                (0, -1),         (0, 1),
                (1, -1), (1, 0), (1, 1)
            };

            foreach (var offset in offsets)
            {
                int adjacentX = coordinates.x + offset.x;
                int adjacentY = coordinates.y + offset.y;
                occupiedCoordinates.Add((adjacentX, adjacentY));
            }
        }


        private static void SeedDistrictsAndStructures(ModelBuilder modelBuilder)
        {
            // Add Mines
            var mines = new List<Mine>
            {
                new Mine { Id = 1, Code = "MINERALS_MINE", GainMultiplier = 200, ResourceId = 1 },
                new Mine { Id = 2, Code = "MICROCHIPS_FACTORY", GainMultiplier = 170, ResourceId = 2 },
                new Mine { Id = 3, Code = "HYDROGEN_MINE", GainMultiplier = 140, ResourceId = 3 },
                new Mine { Id = 4, Code = "ENERGY_GENERATOR", GainMultiplier = 170, ResourceId = 7 },
                new Mine { Id = 5, Code = "NUCLEAR_REACTOR", GainMultiplier = 210, ResourceId = 7 },
                new Mine { Id = 6, Code = "FOOD_FARM", GainMultiplier = 150, ResourceId = 4 }
            };

            // Add Structures
            var structures = new List<Structure>
            {
                new Structure { Id = 1, Name = "City Hall", Description = "The central administrative building where laws are enacted and the region is governed.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 2, Name = "Raw Material Mine", Description = "A mine that extracts essential minerals from the planet’s crust.", MineId = 1, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 2000 },
                new Structure { Id = 3, Name = "Microchip Factory", Description = "A specialized facility for producing advanced microchips needed for high-tech devices.", MineId = 2, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 3000 },
                new Structure { Id = 4, Name = "Hydrogen Mine", Description = "A facility that extracts hydrogen, used as fuel for spacecraft and energy production.", MineId = 3, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 4000 },
                new Structure { Id = 5, Name = "Energy Generator", Description = "A generator that produces energy to power the region's infrastructure.", MineId = 4, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 5000 },
                new Structure { Id = 6, Name = "Nuclear Reactor", Description = "A powerful reactor that generates large amounts of energy for the region.", MineId = 5, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 6000 },
                new Structure { Id = 7, Name = "Farmland", Description = "Fields dedicated to agriculture, producing food to sustain the population.", MineId = 6, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 7000 },
                new Structure { Id = 8, Name = "Residential Area", Description = "Housing complexes that provide homes for the population, increasing happiness.", CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 8000 },
                new Structure { Id = 9, Name = "Spaceport", Description = "A facility that allows for the recruitment and maintenance of spacecraft.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 9000 },
                new Structure { Id = 10, Name = "Barracks", Description = "A military facility where ground troops are recruited and trained.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 10000 },
                new Structure { Id = 11, Name = "Research Center", Description = "A hub for scientific research, unlocking new technologies for the region.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 11000 }
            };

            // Apply seed data to modelBuilder
            modelBuilder.Entity<Mine>().HasData(mines);
            modelBuilder.Entity<Structure>().HasData(structures);
        }

        private static void SeedCards(ModelBuilder modelBuilder)
        {
            // Crear cartas
            var cards = new List<Card>
            {
                new Card
                {
                    Id = 1,
                    Name = "Kily Gavin",
                    Description = "A well-known governor focused on boosting production at all costs.",
                    ImageUrl = "https://art.ngfiles.com/images/374000/374499_unknowndepths_sci-fi-card-template-example-01-rear.jpg?f1440462500"
                },
                new Card
                {
                    Id = 2,
                    Name = "Faster Krate",
                    Description = "An efficient governor known for reducing the time to complete projects.",
                    ImageUrl = "https://art.ngfiles.com/images/374000/374499_unknowndepths_sci-fi-card-template-example-01-rear.jpg?f1440462500"
                }
            };

                    // Crear bonos de cartas
            var cardBonuses = new List<CardBonus>
            {
                new CardBonus
                {
                    Id = 1,
                    CardId = 1,
                    Title = "Production Boost: Minerals",
                    Description = "Increases the production output of the mineral mine by 20%.",
                    BonusType = EBonusType.ResourceProductionBoost,
                    StructureId = 2, // Mineral Mine
                    Percentage = 20
                },
                new CardBonus
                {
                    Id = 2,
                    CardId = 1,
                    Title = "Production Boost: Microchips",
                    Description = "Increases the production output of the microchip factory by 15%.",
                    BonusType = EBonusType.ResourceProductionBoost,
                    StructureId = 3, // Microchip Factory
                    Percentage = 15
                },
                new CardBonus
                {
                    Id = 3,
                    CardId = 1,
                    Title = "Increased Energy Consumption",
                    Description = "Increases energy consumption of the mineral mine by 10%.",
                    BonusType = EBonusType.EnergyConsumption,
                    StructureId = 2, // Mineral Mine
                    Percentage = 10
                },
                new CardBonus
                {
                    Id = 4,
                    CardId = 2,
                    Title = "Construction Time Reduction",
                    Description = "Reduces construction time for all structures in the region by 30%.",
                    BonusType = EBonusType.StructureTime,
                    StructureId = null, // Applies to all structures
                    Percentage = -30
                }
            };

            // Aplicar los datos de cartas y bonos al modelBuilder
            modelBuilder.Entity<Card>().HasData(cards);
            modelBuilder.Entity<CardBonus>().HasData(cardBonuses);
        }

        private static void SeedArmy(ModelBuilder modelBuilder)
        {
            // Crear flotas
            var fleets = new List<Fleet>
            {
                new Fleet
                {
                    Id = 1,
                    Name = "Alpha Fleet",
                    CoordinateX = 2,
                    CoordinateY = 3,
                    UserId = "33b576ef-5997-4fe9-b93e-c0ad1cabf6e5",
                    SolarSystemId = 1
                },
                new Fleet
                {
                    Id = 2,
                    Name = "Beta Fleet",
                    CoordinateX = 5,
                    CoordinateY = 6,
                    UserId = "33b576ef-5997-4fe9-b93e-c0ad1cabf6e5",
                    SolarSystemId = 1
                }
            };

            modelBuilder.Entity<Fleet>().HasData(fleets);

            // Crear naves
            var ships = new List<Ship>
            {
                new Ship { Id = 1, Name = "Lanzadera", Img = "spaceship_test.jpg", Function = EShipFunction.Transport, Strenght = 50, Shields = 30, Health = 200, Maniobrability = 10, Ability = 5, Speed = 8, CargoCapacity = 1000, MineralsCost = 500, MicrochipsCost = 100, HydrogenCost = 50, CreditsCost = 1000 },
                new Ship { Id = 2, Name = "Carguero", Img = "spaceship_test.jpg", Function = EShipFunction.Transport, Strenght = 40, Shields = 20, Health = 300, Maniobrability = 8, Ability = 6, Speed = 7, CargoCapacity = 2000, MineralsCost = 700, MicrochipsCost = 150, HydrogenCost = 100, CreditsCost = 1500 },
                new Ship { Id = 3, Name = "Dron de ataque", Img = "spaceship_test.jpg", Function = EShipFunction.FastAttack, Strenght = 100, Shields = 40, Health = 80, Maniobrability = 20, Ability = 15, Speed = 12, CargoCapacity = 50, MineralsCost = 300, MicrochipsCost = 50, HydrogenCost = 30, CreditsCost = 500 },
                new Ship { Id = 4, Name = "Caza clase K", Img = "spaceship_test.jpg", Function = EShipFunction.Attack, Strenght = 120, Shields = 50, Health = 150, Maniobrability = 18, Ability = 20, Speed = 10, CargoCapacity = 80, MineralsCost = 600, MicrochipsCost = 120, HydrogenCost = 80, CreditsCost = 1200 },
                new Ship { Id = 5, Name = "Caza clase Vengador", Img = "spaceship_test.jpg", Function = EShipFunction.Attack, Strenght = 180, Shields = 80, Health = 180, Maniobrability = 17, Ability = 25, Speed = 12, CargoCapacity = 100, MineralsCost = 800, MicrochipsCost = 150, HydrogenCost = 100, CreditsCost = 2000 },
                new Ship { Id = 6, Name = "Fragata ligera", Img = "spaceship_test.jpg", Function = EShipFunction.Attack, Strenght = 200, Shields = 100, Health = 300, Maniobrability = 15, Ability = 30, Speed = 9, CargoCapacity = 150, MineralsCost = 1000, MicrochipsCost = 200, HydrogenCost = 150, CreditsCost = 3000 },
                new Ship { Id = 7, Name = "Fragata pesada", Img = "spaceship_test.jpg", Function = EShipFunction.Heavy, Strenght = 250, Shields = 120, Health = 400, Maniobrability = 12, Ability = 35, Speed = 8, CargoCapacity = 200, MineralsCost = 1500, MicrochipsCost = 300, HydrogenCost = 200, CreditsCost = 4000 },
                new Ship { Id = 8, Name = "Destructor", Img = "spaceship_test.jpg", Function = EShipFunction.Heavy, Strenght = 300, Shields = 150, Health = 500, Maniobrability = 10, Ability = 40, Speed = 7, CargoCapacity = 250, MineralsCost = 2000, MicrochipsCost = 400, HydrogenCost = 300, CreditsCost = 5000 },
                new Ship { Id = 9, Name = "Crucero", Img = "spaceship_test.jpg", Function = EShipFunction.Heavy, Strenght = 350, Shields = 180, Health = 600, Maniobrability = 9, Ability = 45, Speed = 6, CargoCapacity = 300, MineralsCost = 2500, MicrochipsCost = 500, HydrogenCost = 400, CreditsCost = 7000 },
                new Ship { Id = 10, Name = "Acorazado", Img = "spaceship_test.jpg", Function = EShipFunction.Mothership, Strenght = 400, Shields = 200, Health = 800, Maniobrability = 8, Ability = 50, Speed = 5, CargoCapacity = 500, MineralsCost = 3000, MicrochipsCost = 600, HydrogenCost = 500, CreditsCost = 10000 }
            };

            modelBuilder.Entity<Ship>().HasData(ships);

            // Crear flotas con naves
            var fleetShips = new List<FleetShip>
            {
                new FleetShip { FleetId = 1, ShipId = 4, Quantity = 32 }, // 32 Cazas clase K en la flota Alpha
                new FleetShip { FleetId = 1, ShipId = 6, Quantity = 10 }, // 10 Fragatas ligeras en la flota Alpha
                new FleetShip { FleetId = 2, ShipId = 5, Quantity = 24 }, // 24 Cazas clase Vengador en la flota Beta
                new FleetShip { FleetId = 2, ShipId = 8, Quantity = 8 },  // 8 Destructores en la flota Beta
                new FleetShip { FleetId = 2, ShipId = 10, Quantity = 1 }  // 1 Acorazado en la flota Beta
            };

            modelBuilder.Entity<FleetShip>().HasData(fleetShips);
        }


    }
}
