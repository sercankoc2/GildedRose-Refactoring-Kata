using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("foo"));
    }
    [Test]
    public void NormalItem_DecreasesQualityAndSellIn()
    {
        var items = new List<Item>
        {
            new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 20 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].SellIn, Is.EqualTo(9));
        Assert.That(items[0].Quality, Is.EqualTo(19));
    }

    [Test]
    public void Quality_NeverNegative()
    {
        var items = new List<Item>
        {
            new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 0 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void AgedBrie_IncreasesQuality()
    {
        var items = new List<Item>
        {
            new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(11));
        Assert.That(items[0].SellIn, Is.EqualTo(9));
    }

    [Test]
    public void AgedBrie_DoesNotExceed50()
    {
        var items = new List<Item>
        {
            new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(50));
    }

    [Test]
    public void Sulfuras_NeverChanges()
    {
        var items = new List<Item>
        {
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].SellIn, Is.EqualTo(5));
        Assert.That(items[0].Quality, Is.EqualTo(80));
    }

    [Test]
    public void BackstagePass_IncreasesBy1WhenSellInAbove10()
    {
        var items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(21));
    }

    [Test]
    public void BackstagePass_IncreasesBy2WhenSellIn10OrLess()
    {
        var items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(22));
    }

    [Test]
    public void BackstagePass_IncreasesBy3WhenSellIn5OrLess()
    {
        var items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(23));
    }

    [Test]
    public void BackstagePass_DropsToZeroAfterConcert()
    {
        var items = new List<Item>
        {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void AllItems_SellInDecreasesExceptSulfuras()
    {
        var items = new List<Item>
        {
            new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
            new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.That(items[0].SellIn, Is.EqualTo(9));
        Assert.That(items[1].SellIn, Is.EqualTo(10));
    }
}