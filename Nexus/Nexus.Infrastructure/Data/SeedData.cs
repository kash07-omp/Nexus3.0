﻿using Microsoft.EntityFrameworkCore;
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
                new Structure { Id = 2, Name = "Raw Material Mine", Description = "A mine that extracts essential minerals from the planet’s crust.", MineId = 1, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 3, Name = "Microchip Factory", Description = "A specialized facility for producing advanced microchips needed for high-tech devices.", MineId = 2, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 4, Name = "Hydrogen Mine", Description = "A facility that extracts hydrogen, used as fuel for spacecraft and energy production.", MineId = 3, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 5, Name = "Energy Generator", Description = "A generator that produces energy to power the region's infrastructure.", MineId = 4, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 6, Name = "Nuclear Reactor", Description = "A powerful reactor that generates large amounts of energy for the region.", MineId = 5, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 7, Name = "Farmland", Description = "Fields dedicated to agriculture, producing food to sustain the population.", MineId = 6, CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 8, Name = "Residential Area", Description = "Housing complexes that provide homes for the population, increasing happiness.", CanLevelUp = true, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 9, Name = "Spaceport", Description = "A facility that allows for the recruitment and maintenance of spacecraft.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 10, Name = "Barracks", Description = "A military facility where ground troops are recruited and trained.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 },
                new Structure { Id = 11, Name = "Research Center", Description = "A hub for scientific research, unlocking new technologies for the region.", CanLevelUp = false, BaseMinerales = 500, BaseChips = 100, BaseHydrogen = 50, BaseEnergy = 0, BaseCredits = 1000 }
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
    }
}
