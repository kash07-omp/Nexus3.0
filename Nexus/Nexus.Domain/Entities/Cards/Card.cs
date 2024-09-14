namespace Nexus.Domain.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public ECardType CardType { get; set; }
        public ECardRarity CardRarity { get; set; }
        public TimeSpan? Duration { get; set; }


        public virtual ICollection<CardBonus> CardBonuses { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }

    public enum ECardType
    {
        Governor,  
        Admiral,
        General,
        Scientist
    }

    public enum ECardRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }
}