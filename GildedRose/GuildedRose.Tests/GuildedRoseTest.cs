using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GuildedRoseTest
{
    [TestMethod]
    public void Foo()
    {
        //--Arranger
        IList<Item> Items = new List<Item>
        {
            new Item {Name = "foo", SellIn = 0, Quality = 0}
        };
        var app = new GildedRose(Items);

        //--Agir
        app.UpdateQuality();

        //--Assertion
        Assert.AreEqual("corrige_moi", Items[0].Name);
    }
}