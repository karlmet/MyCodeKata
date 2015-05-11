namespace GuildedRose.Console.Item
{
    public class LegendaryDecoration : ItemDecorator
    {
        public ItemBase DecoratedItem;

        public LegendaryDecoration(ItemBase item)
        {
            DecoratedItem = item;
        }

        protected override void UpdateSellIn()
        {
            DecoratedItem.Item.SellIn = DecoratedItem.Item.SellIn;
        }

        protected override void UpdateQuality()
        {
            DecoratedItem.Item.SellIn = DecoratedItem.Item.SellIn;
        }
    }
}