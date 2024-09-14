using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface ICardService
    {
        Task<Card> OpenChest(ChestType chestType);
        Task AssignCardToUserAsync(User user, Card card);
        Task<List<Card>> GetUserCardsAsync(string userId);
    }
}