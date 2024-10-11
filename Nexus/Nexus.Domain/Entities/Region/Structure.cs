using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus.Domain.Entities
{
    public class Structure
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool CanLevelUp { get; set; }
        public short? MineId { get; set; }

        public int BaseMinerales { get; set; }
        public int BaseChips { get; set; }
        public int BaseHydrogen { get; set; }
        public int BaseEnergy { get; set; }
        public int BaseCredits { get; set; }
        // TODO: Terminar de definir esto. La idea es que cada structure suba de nivel con la formula Coste = CosteBase * CostMultiplier^Level
        //public int CostMultiplier { get; set; }

        [NotMapped]
        public string SimplifiedName => Name.ToLower().Replace(' ', '-');

        public virtual Mine Mine { get; set; }
    }
}
