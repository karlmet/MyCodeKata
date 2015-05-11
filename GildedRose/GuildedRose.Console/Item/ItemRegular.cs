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
            Item.Quality = Item.Quality-1;
        }
    }
}