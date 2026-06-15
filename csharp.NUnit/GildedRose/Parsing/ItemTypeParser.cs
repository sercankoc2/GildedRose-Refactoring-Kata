using GildedRoseKata.Enum;

namespace GildedRoseKata.Parsing;

public static class ItemTypeParser
{
    public static ItemType ParseFromName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return ItemType.Normal;

        if (name.Contains("Aged Brie")) return ItemType.AgedBrie;
        if (name.Contains("Sulfuras")) return ItemType.Sulfuras;
        if (name.Contains("Backstage passes")) return ItemType.BackstagePass;
        if (name.Contains("Conjured")) return ItemType.Conjured;

        return ItemType.Normal;
    }
}

