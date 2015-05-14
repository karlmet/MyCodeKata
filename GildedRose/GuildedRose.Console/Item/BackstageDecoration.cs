namespace GuildedRose.Console.Item
{
    public class BackstageDecoration : ItemDecorator
    {

        public BackstageDecoration(ItemBase itemToDecorate)
        {
            Item = itemToDecorate.Item;
        }


        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (Item.SellIn > 10)
                    UpgradeQualityNormally();
                else if (Item.SellIn <= 10 && Item.SellIn > 5)
                    UpgradeQualityTwice();

                else if (Item.SellIn <= 5 && Item.SellIn > 0)
                    UpgradeQualityThrice();
                else
                    Item.Quality = 0;
            }
        }
    }
}