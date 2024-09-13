namespace Nexus.Domain.Entities
{
    public class CardBonus
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }

        public EBonusType BonusType { get; set; }
        public int Percentage { get; set; }
        public int? StructureId { get; set; }
        public virtual Structure? Structure { get; set; }

        public int CardId { get; set; }
        public virtual Card Card { get; set; }
    }

    public enum EBonusType
    {
        StructureTime,
        ResourceProductionBoost,
        EnergyConsumption
    }
}