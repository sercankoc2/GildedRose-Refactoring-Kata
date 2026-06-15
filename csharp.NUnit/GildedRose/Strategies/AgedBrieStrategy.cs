using System;

namespace GildedRoseKata.Strategies;

public class AgedBrieStrategy : IItemUpdateStrategy
{
    public void Update(Item item)
    {
        item.SellIn--;
        var recovery = item.SellIn < 0 ? 2 : 1;
        item.Quality = Math.Min(50, item.Quality + recovery);
    }
}

