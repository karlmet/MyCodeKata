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
    }
}
