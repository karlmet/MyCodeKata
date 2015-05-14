﻿namespace GuildedRose.Console.Item
{
    public class AgedBrieDecoration : ItemDecorator
    {

        public AgedBrieDecoration(ItemBase itemToDecorate)
        {
            Item = itemToDecorate.Item;
        }


        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (IsSellInEnded() )
                    UpgradeQualityTwice();
                else
                    UpgradeQualityNormally(); 
            }
        }
    }
}