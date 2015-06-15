﻿using System;
using System.Collections.Generic;
using GuildedRose.Console.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuildedRose.Tests
{

    //Les éléments « Rare » se dégradent en qualité moins fréquemment que les autres types.
    //Lors des jours de « Sellin » impairs, il ne se dégradent pas      ex:
    // Rare Damarian Sword sellin   10  Quality 20
    // Rare Damarian Sword sellin   9  Quality 19
    // Rare Damarian Sword sellin   8  Quality 19
    // Rare Damarian Sword sellin   7  Quality 18
    // Rare Damarian Sword sellin   6  Quality 18
    // Rare Damarian Sword sellin   5  Quality 17
   
    [TestClass]
    public class RareItemTest
    {
       
        [TestMethod]
        public void RareItem_SellInEvenNumber_QualityDegradeNormally()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Rare Damarian Sword", SellIn = 10, Quality = 20 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);
        }

        [TestMethod]
        public void RareItem_SellEvenOddNumber_QualityNoDegrade()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Rare Damarian Sword", SellIn = 9, Quality =19 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(8, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);
        }

        [TestMethod]
        public void RareItem_SellInLower5Times_QualityDegrade3()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Rare Damarian Sword", SellIn = 10, Quality = 20 }
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
            Assert.AreEqual(17, Items[0].Quality);
        }

        [TestMethod]
        public void RareItem_SellInNegativeEvenNumber_QualityDegradeTwice()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Rare Damarian Sword", SellIn = -2, Quality = 10 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-3, Items[0].SellIn);
            Assert.AreEqual(8, Items[0].Quality);
        }

        [TestMethod]
        public void RareItem_SellNegativeOddNumber_QualityNoDegrade()
        {
            //--Arrange
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Rare Damarian Sword", SellIn = -3, Quality =10 }
            };
            var app = new GildedRose(Items);

            //--Act
            app.UpdateQuality();

            //--Assert
            Assert.AreEqual(-4, Items[0].SellIn);
            Assert.AreEqual(10, Items[0].Quality);
        }

    }
}
