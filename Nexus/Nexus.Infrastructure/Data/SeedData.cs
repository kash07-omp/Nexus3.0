using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
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
    }
}
