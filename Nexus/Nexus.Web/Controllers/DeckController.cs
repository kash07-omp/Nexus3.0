using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Services.Interfaces;

public class DeckController : Controller
{
    private readonly ICardService _cardService;
    private readonly UserManager<User> _userManager;

    public DeckController(ICardService cardService, UserManager<User> userManager)
    {
        _cardService = cardService;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var cards = await _cardService.GetUserCardsAsync(user.Id);
        return View(cards);
    }

    [HttpPost]
    public async Task<IActionResult> BuyChest(ChestType chestType)
    {
        try
        {
            var user = await _userManager.Users
                .Include(u => u.Cards)
                .FirstOrDefaultAsync(u => u.Id == _userManager.GetUserId(User));

            int chestCost = chestType switch
            {
                ChestType.Normal => 100,
                ChestType.Gold => 300,
                ChestType.Platinum => 500,
                _ => 100
            };

            if (user.Credits < chestCost)
                return Json(new { success = false, message = "Not enough credits" });

            user.Credits -= chestCost;

            var chestResult = await _cardService.OpenChest(chestType, user);

            if (!chestResult.Success)
                return Json(new { success = false, message = chestResult.ErrorMessage });

            await _cardService.AssignCardToUserAsync(user, chestResult.Value!);
            await _userManager.UpdateAsync(user);

            return Json(new { success = true, card = chestResult.Value });
        }
        catch (Exception ex)
        {
            // Log the exception in the server log for further investigation
            // Optionally you can log ex.Message or the full stack trace
            return Json(new { success = false, message = "An unexpected error occurred: " + ex.Message });
        }
    }
}
