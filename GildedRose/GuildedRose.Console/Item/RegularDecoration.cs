namespace GuildedRose.Console.Item
{
    public class RegularDecoration : DecorationBase 
    {
        public RegularDecoration(Item item)
        {
            _Item = item;
        }

        protected override void UpdateQuality()
        {
            _Item.Quality = _Item.Quality-1;
        }
    }
}