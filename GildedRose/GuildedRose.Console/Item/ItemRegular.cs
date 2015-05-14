namespace GuildedRose.Console.Item
{
    public class ItemRegular : ItemBase 
    {
        public ItemRegular(Item item)
        {
            Item = item;
        }

        protected override void UpdateQuality()
        {
            if (IsSellInEnded())
                DecreaseQualityTwice();
            else
                DecreaseQualityNormally();    
        }
    }
}