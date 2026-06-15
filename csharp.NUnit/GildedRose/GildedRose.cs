using System.Collections.Generic;
using GildedRoseKata.Factories;
using GildedRoseKata.Parsing;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            var type = ItemTypeParser.ParseFromName(item.Name);
            var strategy = ItemStrategyFactory.GetStrategy(type);
            strategy.Update(item);
        }
    }
}
