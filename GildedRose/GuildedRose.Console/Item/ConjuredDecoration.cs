namespace GuildedRose.Console.Item
{
    public class ConjuredDecoration : ItemDecorator
    {

        public ConjuredDecoration(ItemBase itemToDecorate) : base(itemToDecorate) { }


        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (IsSellInEnded())
                    DecreaseQualityQuadrice();
                else
                    DecreaseQualityTwice();
                

            }
        }
    }
}