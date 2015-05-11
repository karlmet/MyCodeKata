using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuildedRose.Console.Item;

namespace GuildedRose.Tests
{
    [TestClass]
    public class LegendaryItemTest
    {

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
}
