namespace GuildedRose.Console.Item
{
    public static class ItemFactory
    {
        public static DecorationBase CreateDecoratedItem(Item itemToDecorate)
        {
            switch (itemToDecorate.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryDecoration(itemToDecorate);
                default:
                    return new RegularDecoration(itemToDecorate);
            }

            
        }     
    }
}