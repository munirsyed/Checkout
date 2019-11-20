using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutApp
{
    public class Checkout
    {

        public Decimal CalculateTotalPrice(List<item> listOfItems)
        {

            if (listOfItems == null)
                throw new ArgumentException("List must be supplied");
            var totalListPrice = 0.0M;
            listOfItems.ForEach((item) =>{

                if (item.ItemName.ToLower() == "apple")
                    totalListPrice += Utility.appleCost;
                if (item.ItemName.ToLower() == "orange")
                    totalListPrice += Utility.orangeCost;



            });

            


            return totalListPrice;
        }
        public Decimal CalculateTotalPriceAndApplyDiscounts(List<item> listOfItems)
        {

            var totalListPrice = CalculateTotalPrice(listOfItems);

            var discountedTotalCost = 0M;

            var discountLogic = new Discount();

            //apply offer
            discountedTotalCost = (Decimal)discountLogic.ApplyBuyOneGetOneFreeApple_Offer(listOfItems);

            discountedTotalCost += (Decimal)discountLogic.ApplyBuyThreePayForTwoOranges_Offer(listOfItems);


            var totalPriceWithDiscountsApplied=(Decimal) totalListPrice - discountedTotalCost;


            return   Decimal.Round(totalPriceWithDiscountsApplied,2);


        }




    }
}
