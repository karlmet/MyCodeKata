namespace GuildedRose.Console.Item
{
    public class SuspiciousDecoration : ItemDecorator
    {
        public SuspiciousDecoration(ItemBase itemToDecorate) : base(itemToDecorate)
        {
        }

        protected override void UpdateQuality()
        {
            if (Item.Quality < MaxValue)
            {
                if (IsSellInNumberIsOdd())
                {
                    if (IsSellInEnded())
                        DecreaseQualityTwice();
                    else
                        DecreaseQualityNormally();    
                }
                else //IsSellInNumberIsEven
                {
                    if (IsSellInEnded())
                        DecreaseQualityQuadrice() ;
                    else
                        DecreaseQualityTwice();
                }



                //if (IsSellInEnded())
                //    DecreaseQualityQuadrice();
                //else
                //    DecreaseQualityTwice();
                
            }
        }
    }
}