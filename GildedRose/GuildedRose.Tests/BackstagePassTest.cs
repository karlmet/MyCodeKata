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
    public class BackstagePassTest
    {

        [TestMethod]
        public void BackstagePass_SellInAt12_QualityUpgrade()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 13, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(12, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePass_SellInAt10_QualityUpgrade()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(10, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePass_SellInAt7_QualityUpgradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(7, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);
        }


        [TestMethod]
        public void BackstagePass_SellInAt2_QualityUpgradeThrice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(2, Items[0].SellIn);
            Assert.AreEqual(13, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePass_SellInAt5_QualityUpgradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(5, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePass_SellInAt0_QualityUpgradeThrice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(13, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePass_SellInLowerThan0_QualityAt0()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
        {
           new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 }
        };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}
