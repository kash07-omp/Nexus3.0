using Microsoft.EntityFrameworkCore;
using Nexus.Infrastructure.Data;

public class StructureUpgradeService
{
    private readonly ApplicationDbContext _context;

    public StructureUpgradeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task ProcessCompletedUpgradesAsync(int regionId)
    {
        var now = DateTime.UtcNow;

        var structuresToUpgrade = await _context.RegionStructures
            .Where(rs => rs.RegionId == regionId && rs.UpgradedAt.HasValue && rs.UpgradedAt.Value <= now)
            .ToListAsync();

        foreach (var structure in structuresToUpgrade)
        {
            structure.Level += 1;
            structure.UpgradedAt = null;
        }

        await _context.SaveChangesAsync();
    }
}
