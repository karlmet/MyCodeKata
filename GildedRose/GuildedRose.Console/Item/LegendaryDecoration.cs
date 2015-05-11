namespace GuildedRose.Console.Item
{
    public class LegendaryDecoration : DecorationBase 
    {
        public LegendaryDecoration(Item item)
        {
            _Item = item;
        }

        protected override void UpdateSellIn()
        {
            _Item.SellIn  = _Item.SellIn ;
        }

        protected override void UpdateQuality()
        {
            _Item.Quality = _Item.Quality;
        }
    }
}