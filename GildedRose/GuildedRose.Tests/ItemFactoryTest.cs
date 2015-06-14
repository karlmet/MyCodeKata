using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuildedRose.Console.Item;

namespace GuildedRose.Tests
{
    [TestClass]
    public class ItemFactoryTest
    {
        [TestMethod]
        public void CreateDecoratedItem_Sulfuras_TypeIsLegendary()
        {
            //--Arrange
            var newItem = new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80};

            //--Act
            var itemDecorated = ItemFactory.CreateDecoratedItem(newItem);

            //--Assert
            Assert.IsInstanceOfType(itemDecorated,typeof(LegendaryDecoration) );
        }

        [TestMethod]
        public void CreateDecoratedItem_Vest_TypeIsRegular()
        {
            //--Arrange
            var newItem = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
    
            //--Act
                var itemDecorated = ItemFactory.CreateDecoratedItem(newItem);

            //--Assert
            Assert.IsInstanceOfType(itemDecorated, typeof(ItemRegular));
        }

        [TestMethod]
        public void CreateDecoratedItem_AgedBrie_TypeIsRegular()
        {
            //--Arrange
            var newItem = new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 };

            //--Act
            var itemDecorated = ItemFactory.CreateDecoratedItem(newItem);

            //--Assert
            Assert.IsInstanceOfType(itemDecorated, typeof(AgedBrieDecoration));
        }

        [TestMethod]
        public void CreateDecoratedItem_BackstagePass_TypeIsBackstagePass()
        {
            //--Arrange
            var newItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 };

            //--Act
            var itemDecorated = ItemFactory.CreateDecoratedItem(newItem);

            //--Assert
            Assert.IsInstanceOfType(itemDecorated, typeof(BackstageDecoration));
        }

        [TestMethod]
        public void CreateDecoratedItem_RareSowrd_TypeIsRare()
        {
            //--Arrange
            var newItem = new Item { Name = "Rare Damarian Steel Sword", SellIn = 10, Quality = 20 };

            //--Act
            var itemDecorated = ItemFactory.CreateDecoratedItem(newItem);

            //--Assert
            Assert.IsInstanceOfType(itemDecorated, typeof(RareDecoration));
        }

      
    }
}
