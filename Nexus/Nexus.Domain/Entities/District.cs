namespace Nexus.Domain.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Structure> Structures { get; set; }
    }
}
