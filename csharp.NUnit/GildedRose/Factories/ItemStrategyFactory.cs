using GildedRoseKata.Enum;
using GildedRoseKata.Strategies;

namespace GildedRoseKata.Factories;

public static class ItemStrategyFactory
{
    public static IItemUpdateStrategy GetStrategy(ItemType itemType)
    {
        return itemType switch
        {
            ItemType.AgedBrie => new AgedBrieStrategy(),
            ItemType.Sulfuras => new SulfurasStrategy(),
            ItemType.BackstagePass => new BackstagePassStrategy(),
            ItemType.Conjured => new ConjuredItemStrategy(),
            ItemType.Normal or _ => new NormalItemStrategy()
        };
    }
}

