﻿namespace GuildedRose.Console.Item
{
    public class RareDecoration : ItemDecorator
    {
        public RareDecoration(ItemBase itemToDecorate) : base(itemToDecorate)
        {
        }

        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (IsSellNumberIsEven())
                {
                    if (IsSellInEnded())
                        DecreaseQualityTwice();
                    else
                        DecreaseQualityNormally();    
                }
            }
        }
    }
}