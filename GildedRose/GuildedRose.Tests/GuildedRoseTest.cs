using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GuildedRoseTest
{
    [TestMethod]
    public void Foo()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
            new Item {Name = "foo", SellIn = 0, Quality = 0}
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual("foo", Items[0].Name);
    }


    [TestMethod]
    public void RegularItem_SellInGreaterThan0_QualityDegradeNormally()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(9, Items[0].SellIn);
        Assert.AreEqual(19, Items[0].Quality);
    }

    [TestMethod]
    public void RegularItem_SellInArriveAt0_QualityDegradeDoubled()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-1, Items[0].SellIn);
        Assert.AreEqual(8, Items[0].Quality);
    }

    [TestMethod]
    public void RegularItem_SellInLower0_QualityDegradeMinAt0()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "+5 Dexterity Vest", SellIn = -5, Quality = 0 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-6, Items[0].SellIn);
        Assert.AreEqual(0, Items[0].Quality);
    }

    //Todo Some bug here with initial quality more than 50
    [TestMethod]
    public void RegularItem_SellInLower0_AndQualityMoreThan50_QualityDegradeMinAt0()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "+5 Dexterity Vest", SellIn = -5, Quality = 60 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-6, Items[0].SellIn);
        Assert.AreEqual(58, Items[0].Quality);
    }


    [TestMethod]
    public void AgedBrieItem_SellGreaterThan0_QualityUpgradeNormally()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "Aged Brie", SellIn = 5, Quality = 10 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(4, Items[0].SellIn);
        Assert.AreEqual(11, Items[0].Quality);
    }

    [TestMethod]
    public void AgedBrieItem_SellInAt0_QualityUpgradeDoubled()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "Aged Brie", SellIn = 0, Quality = 10 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-1, Items[0].SellIn);
        Assert.AreEqual(12, Items[0].Quality);
    }

    [TestMethod]
    public void AgedBrieItem_SellLowerThan0_QualityMaxAt50()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "Aged Brie", SellIn = -10, Quality = 50 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-11, Items[0].SellIn);
        Assert.AreEqual(50, Items[0].Quality);
    }

    //Todo Some bug here with initial quality more than 50
    [TestMethod]
    public void AgedBrieItem_SellLowerThan0_QualityMoreThan50_QualityMaxAt50()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "Aged Brie", SellIn = -10, Quality = 60 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(-11, Items[0].SellIn);
        Assert.AreEqual(60, Items[0].Quality);
    }


    [TestMethod]
    public void LegendaryItem_SellInAt0_QualityDontChange()
    {
        //--Arrange
        IList<Item> Items = new List<Item>
        {
           new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }
        };
        var app = new GildedRose(Items);

        //--Act
        app.UpdateQuality();

        //--Assert
        Assert.AreEqual(0, Items[0].SellIn);
        Assert.AreEqual(80, Items[0].Quality);
    }
}