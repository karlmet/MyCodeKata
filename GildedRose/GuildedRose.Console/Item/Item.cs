namespace GuildedRose.Console.Item
{
    public class Item
    {
        private string aName;
        private int aSellIn;
        private int aQuality;

        public string Name
        {
            get { return aName; }
            set { aName = value; }
        }

        public int SellIn
        {
            get { return aSellIn; }
            set { aSellIn = value; }
        }

        public int Quality
        {
            get { return aQuality; }
            set { aQuality = value; }
        }
    }
}