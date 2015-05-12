using System.Collections.Generic;
using GuildedRose.Console.Item;

namespace GuildedRose.Console.Item
{
    public abstract class ItemBase
    {
        public Item Item;
        protected  const int MaxValue = 50;
        protected const int MinValue = 0;

        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        protected bool IsSellEnded()
        {
            return Item.SellIn <= 0;
        }

        private bool IsActualQualityValid()
        {
            return Item.Quality <= 50 && Item.Quality >= 0;
        }

        private bool IsQualityValid(int quality)
        {
            return quality <= 50 && quality >= 0;
        }

        protected virtual void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }

        protected abstract void UpdateQuality();

        protected void UpgradeQualityTwice()
        {
            Item.Quality = Item.Quality + 2;
        }

        protected void UpgradeQualityNormally()
        {
            Item.Quality = Item.Quality + 1;
        }

        protected void DecreaseQualityNormally()
        {
            if (IsActualQualityValid() && IsQualityValid(Item.Quality - 1))
                Item.Quality = Item.Quality - 1;
        }

        protected void DecreaseQualityTwice()
        {
            if (IsActualQualityValid() && IsQualityValid(Item.Quality - 2))
                Item.Quality = Item.Quality - 2;
        }
    }
}
