using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        // For every Item in the list:
        for (var i = 0; i < Items.Count; i++)
        {
            if (
                Items[i].Name != "Aged Brie"
                && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert"
            )
            {
                // Decrease the Quality of "normal" items by 1, if Quality is greater than 0
                if (Items[i].Quality > 0)
                {
                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }
            }
            else
            {
                if (Items[i].Quality < 50)
                {
                    // Increase Quality for every item by 1, if Quality is less than 50
                    Items[i].Quality = Items[i].Quality + 1;

                    // If the item is a "Backstage pass":
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        // Increase by an additional 1 if SellIn is 10 or less
                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }

                        // Increase by an additional 1 if SellIn is 5 or less
                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                }
            }

            // Decrease the SellIn by 1 for every item, except for "Sulfuras"
            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name != "Aged Brie")
                {
                    if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                // Decrease Quality by 1 for every "normal" item if Quality is greater than 0
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        // Set Quality to 0 if item is a "Backstage pass"
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
                else
                {
                    // Increase the Quality if the item is "Aged Brie" and Quality is less than 50
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
            }
        }
    }
}
