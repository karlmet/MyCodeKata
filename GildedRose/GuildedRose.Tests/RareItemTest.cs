using System;
using System.Collections.Generic;
using GuildedRose.Console.Item;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuildedRose.Tests
{

    //Les éléments « Rare » se dégradent en qualité moins fréquemment que les autres types.
    //Lors des jours de « Sellin » impairs, il ne se dégradent pas      exL:
    // Rare Damarian Sword sellin   10  Quality 20
    // Rare Damarian Sword sellin   9  Quality 19
    // Rare Damarian Sword sellin   8  Quality 19
    // Rare Damarian Sword sellin   7  Quality 18
    // Rare Damarian Sword sellin   7  Quality 18
                 
    //Les éléments « Douteux » se dégradent en qualité plus fréquemment que les autres types. Lors des jours de « Sellin » pairs, ils se dégradent deux fois plus vite.

    [TestClass]
    public class RareItemTest
    {
       
        [TestMethod]
        public void RereItem_SellInEvenNumber_QualityDegradeNormally()
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
        public void RereItem_SellInOddNumber_QualityDontDegrade()
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
    
    }
}
