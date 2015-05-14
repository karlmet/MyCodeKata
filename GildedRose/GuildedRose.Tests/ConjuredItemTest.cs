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
    public class ConjuredItemTest
    {
        //Les éléments "Conjured" se dégradent en qualité deux fois plus vite que les objets normaux 
        [TestMethod]
        public void ConjuredItem_SellInGreaterThan0_QualityDegradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Conjured Mana Sword", SellIn = 10, Quality = 30 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(28, Items[0].Quality);
        }

        [TestMethod]
        public void ConjuredItem_SellInLowerThan0_QualityDegradeQuatro()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Conjured Mana Sword", SellIn = 0, Quality = 10 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(6, Items[0].Quality);
        }


    }
}
