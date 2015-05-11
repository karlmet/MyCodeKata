using System.Collections.Generic;
using GuildedRose.Console.Item;

namespace GuildedRose.Console.Item
{
    public abstract class ItemBase
    {
        public Item Item;

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }


        protected virtual void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }

        protected abstract void UpdateQuality();
    }
}
