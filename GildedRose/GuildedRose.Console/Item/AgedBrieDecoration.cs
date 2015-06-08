namespace GuildedRose.Console.Item
{
    public class AgedBrieDecoration : ItemDecorator
    {

        public AgedBrieDecoration(ItemBase itemToDecorate) : base(itemToDecorate) { }

        //public AgedBrieDecoration( )
        //{

        //}

        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (IsSellInEnded() )
                    UpgradeQualityTwice();
                else
                    UpgradeQualityNormally(); 
            }
        }
    }
}