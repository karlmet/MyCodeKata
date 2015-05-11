namespace GuildedRose.Console.Item
{
    public static class ItemFactory
    {
        public static ItemBase CreateDecoratedItem(Item itemToDecorate)
        {
            switch (itemToDecorate.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    ItemBase item = new ItemRegular(itemToDecorate);
                    item = new LegendaryDecoration(item);
                    return item;
                  
                default:
                    return new ItemRegular(itemToDecorate);
            }

            
        }     
    }
}