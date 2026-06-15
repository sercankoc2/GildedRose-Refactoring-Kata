using System;

namespace GildedRoseKata.Strategies;

public class BackstagePassStrategy : IItemUpdateStrategy
{
    public void Update(Item item)
    {
        item.SellIn--;

        if (item.SellIn < 0)
        {
            item.Quality = 0;
            return;
        }

        var increment = item.SellIn switch
        {
            < 5 => 3,
            < 10 => 2,
            _ => 1
        };

        item.Quality = Math.Min(50, item.Quality + increment);
    }
}

