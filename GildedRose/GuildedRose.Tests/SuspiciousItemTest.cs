using System;
using System.Collections.Generic;
using GuildedRose.Console.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuildedRose.Tests
{

    //Les éléments « Douteux » se dégradent en qualité plus fréquemment que les autres types.
    //Lors des jours de « Sellin » pairs, ils se dégradent deux fois plus vite.

    // Suspicious Wooden shield sellin   10  Quality 20
    // Rare Damarian Sword sellin   9  Quality 18
    // Rare Damarian Sword sellin   8  Quality 17
    // Rare Damarian Sword sellin   7  Quality 15
    // Rare Damarian Sword sellin   6  Quality 14
    // Rare Damarian Sword sellin   5  Quality 12
    //..
    //  
   
    [TestClass]
    public class SuspiciousItemTest
    {
       
        [TestMethod]
        public void SuspiciousItem_SellInEvenNumber_QualityDegradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Suspicious Wooden shield", SellIn = 10, Quality = 20 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(18, Items[0].Quality);
        }

        [TestMethod]
        public void SuspiciousItem_SellInOddQualityDegradeNormally()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Suspicious Wooden shield", SellIn = 9, Quality =19 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(8, Items[0].SellIn);
            Assert.AreEqual(18, Items[0].Quality);
        }

        [TestMethod]
        public void SuspiciousItem_SellInLower5Times_QualityDegrade8()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Suspicious Wooden shield", SellIn = 10, Quality = 20 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(5, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);
        }

        [TestMethod]
        public void SuspiciousItem_SellInNegativeEvenNumber_QualityDegradeQuadrice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Suspicious Wooden shield", SellIn = -2, Quality = 10 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-3, Items[0].SellIn);
            Assert.AreEqual(6, Items[0].Quality);
        }

        [TestMethod]
        public void SuspiciousItem_SellNegativeOddNumber_Quality_DegradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Suspicious Wooden shield", SellIn = -3, Quality =10 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-4, Items[0].SellIn);
            Assert.AreEqual(8, Items[0].Quality);
        }

    }
}
