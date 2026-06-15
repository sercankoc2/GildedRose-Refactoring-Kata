using System;

namespace GildedRoseKata.Strategies;

public class NormalItemStrategy : IItemUpdateStrategy
{
    public void Update(Item item)
    {
        item.SellIn--;
        var decay = item.SellIn < 0 ? 2 : 1;
        item.Quality = Math.Max(0, item.Quality - decay);
    }
}

