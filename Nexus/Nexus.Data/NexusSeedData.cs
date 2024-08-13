using Nexus.Model;
using System.Data.Entity;

namespace Nexus.Data
{
    public class NexusSeedData : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            GetResources().ForEach(r => context.Resources.Add(r));

            context.SaveChanges();
        }

        private static List<Resource> GetResources()
        {
            return new List<Resource>
            {
                new Resource { Code = "MNR", Name = "Minerals", Description = "Basic construction material." },
                new Resource { Code = "MCP", Name = "Microchips", Description = "Used in advanced technology manufacturing." },
                new Resource { Code = "H2", Name = "Hydrogen", Description = "Primary fuel for spaceships and advanced reactors." },
                new Resource { Code = "FOD", Name = "Food", Description = "Necessary to sustain population." },
                new Resource { Code = "CRD", Name = "Credits", Description = "Currency used for trading and transactions." },
                new Resource { Code = "NRG", Name = "Energy", Description = "Power supply for buildings." },
                new Resource { Code = "POP", Name = "Population", Description = "Represents the number of people available for work and colonization." }
            };
        }
    }

}
