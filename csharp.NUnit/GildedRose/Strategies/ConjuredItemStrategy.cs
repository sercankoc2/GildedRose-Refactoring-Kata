using System;

namespace GildedRoseKata.Strategies;

public class ConjuredItemStrategy : IItemUpdateStrategy
{
    public void Update(Item item)
    {
        item.SellIn--;
        var decay = item.SellIn < 0 ? 4 : 2;
        item.Quality = Math.Max(0, item.Quality - decay);
    }
}

