namespace GuildedRose.Console.Item
{
    public class LegendaryDecoration : ItemDecorator
    {
        public LegendaryDecoration(ItemBase itemToDecorate)
        {
           Item = itemToDecorate.Item;
        }

        protected override void UpdateSellIn()
        {
           Item.SellIn = Item.SellIn;
        }

        protected override void UpdateQuality()
        {
           Item.SellIn = Item.SellIn;
        }
    }
}