namespace GuildedRose.Console.Item
{
    public static class ItemFactory
    {
        public static ItemBase CreateDecoratedItem(Item itemToDecorate)
        {
            ItemBase item = new ItemRegular(itemToDecorate);

            if (itemToDecorate.Name.Contains("Sulfuras"))
                item = new LegendaryDecoration(item);

            else if (itemToDecorate.Name.Contains("Aged Brie"))
                item = new AgedBrieDecoration(item);

            else if (itemToDecorate.Name.Contains("Backstage passes"))
                item = new BackstageDecoration(item);

            else if (itemToDecorate.Name.Contains("Conjured"))
                item = new ConjuredDecoration(item);

            else if (itemToDecorate.Name.Contains("Rare"))
                item = new RareDecoration(item);

            else if (itemToDecorate.Name.Contains("Suspicious"))
                item = new SuspiciousDecoration(item);

            return item;
        }
    }
}