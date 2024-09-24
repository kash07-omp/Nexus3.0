using Nexus.Domain.Entities;
using Nexus.Infrastructure.Common;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface ICardService
    {
        Task<Result<Card>> OpenChest(ChestType chestType, User user);
        Task AssignCardToUserAsync(User user, Card card);
        Task<List<Card>> GetUserCardsAsync(string userId);
        Task<Result<object>> SetRegionGovernor(int regionId, int cardId, string userId);
    }
}