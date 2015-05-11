using System.Collections.Generic;
using GuildedRose.Console.Item;

namespace GuildedRose.Console.Item
{
    public abstract class DecorationBase
    {
        public Item _Item;

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }


        protected virtual void UpdateSellIn()
        {
            _Item.SellIn = _Item.SellIn - 1;
        }

        protected abstract void UpdateQuality();
    }
}
