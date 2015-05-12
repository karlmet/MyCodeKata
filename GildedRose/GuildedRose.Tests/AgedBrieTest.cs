using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildedRose.Console.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuildedRose.Tests
{
    [TestClass]
    public class AgedBrieTest
    {

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

    }
}
