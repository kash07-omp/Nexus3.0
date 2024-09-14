using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Common;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;

public class CardService : ICardService
{
    private readonly ApplicationDbContext _context;

    public CardService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result<Card>> OpenChest(ChestType chestType, User user)
    {
        try
        {
            var rarity = GetRarityFromChest(chestType);
            var availableCards = await GetAvailableCardsAsync(rarity, user);

            if (!availableCards.Any())
                return Result<Card>.FailureResult($"You already own all {nameof(rarity)} cards.");

            // Seleccionar carta aleatoria
            var random = new Random();
            var selectedCard = availableCards[random.Next(availableCards.Count)];

            return Result<Card>.SuccessResult(selectedCard);
        } catch (Exception ex)
        {
            return Result<Card>.FailureResult($"Ups! the gorgomits has break interfer in this action ({ex})");
        }
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

    private async Task<List<Card>> GetAvailableCardsAsync(ECardRarity rarity, User user)
    {
        var userCardIds = user.Cards
            .Where(c => c.Duration == null)
            .Select(c => c.Id)
            .ToList();

        return await _context.Cards
            .Where(c => c.CardRarity == rarity && !userCardIds.Contains(c.Id))
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