using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutApp
{
    public class Discount
    {
         public Decimal ApplyBuyOneGetOneFreeApple_Offer(List<item> listOfItems)
        {

            var countOfApples = listOfItems.Where(x => x.ItemName.ToLower() == "apple").Count();
            Decimal discountPercent = 0.5M;
            var totalCostOfApplesWithoutDiscount = Utility.appleCost * countOfApples;
            return (Decimal)totalCostOfApplesWithoutDiscount * discountPercent;

        }

        public Decimal ApplyBuyThreePayForTwoOranges_Offer(List<item> listOfItems)
        {

            var countOfOranges = listOfItems.Where(x => x.ItemName.ToLower() == "orange").Count();
            Decimal discountPercent = 2M / 3M;
            var totalCostOfOrangesWithoutDiscount = Utility.orangeCost * countOfOranges;
            return (Decimal) totalCostOfOrangesWithoutDiscount * discountPercent;



        }
    }
}
