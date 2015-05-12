namespace GuildedRose.Console.Item
{
    public static class ItemFactory
    {
        public static ItemBase CreateDecoratedItem(Item itemToDecorate)
        {
            ItemBase item = new ItemRegular(itemToDecorate);

            switch (itemToDecorate.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    item = new LegendaryDecoration(item);
                    break;

                case "Aged Brie":
                    item = new AgedBrieDecoration(item);
                    break;
            
            }
            return item;
        }     
    }
}