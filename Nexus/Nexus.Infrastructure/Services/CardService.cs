using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;

public class CardService : ICardService
{
    private readonly ApplicationDbContext _context;

    public CardService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Card> OpenChest(ChestType chestType)
    {
        ECardRarity rarity = GetRarityFromChest(chestType);
        Random random = new Random();

        List<Card> cards = await _context.Cards
            .Where(c => c.CardRarity == rarity)
            .ToListAsync();

        return cards[random.Next(cards.Count)];
    }

    public async Task AssignCardToUserAsync(User user, Card card)
    {
        user.Cards.Add(card);
        _context.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Card>> GetUserCardsAsync(string userId)
    {
        return await _context.Users
            .Where(u => u.Id == userId)
            .SelectMany(u => u.Cards)
            .ToListAsync();
    }

    private ECardRarity GetRarityFromChest(ChestType chestType)
    {
        return chestType switch
        {
            ChestType.Normal => RollProbability(0.7, 0.2, 0.09, 0.01),
            ChestType.Gold => RollProbability(0.4, 0.4, 0.15, 0.05),
            ChestType.Platinum => RollProbability(0.1, 0.5, 0.3, 0.1),
            _ => ECardRarity.Common,
        };
    }

    private ECardRarity RollProbability(double commonChance, double rareChance, double epicChance, double legendaryChance)
    {
        double random = new Random().NextDouble();

        if (random < commonChance) return ECardRarity.Common;
        if (random < commonChance + rareChance) return ECardRarity.Rare;
        if (random < commonChance + rareChance + epicChance) return ECardRarity.Epic;
        return ECardRarity.Legendary;
    }
}

public enum ChestType
{
    Normal,
    Gold,
    Platinum
}

