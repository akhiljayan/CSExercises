using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of TV required: ");
            int tvQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of DVD required: ");
            int dvdQty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of MP3 required: ");
            int mp3Qty = Convert.ToInt32(Console.ReadLine());
            double discountedPrice = CalculateTotalPrice(tvQty, dvdQty, mp3Qty);

            Console.WriteLine("\nDiscounted Price is: {0}", discountedPrice);
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double discountDvd;
            double discountTv;

            double costTv = tvQty * 900;
            double costDvd = dvdQty * 500;
            double costMp3 = mp3Qty * 700;

            if (costTv >= 5000 && costTv < 10000)
            {
                discountTv = ((double)10 / 100) * costTv;
            }
            else if (costTv >= 10000)
            {
                discountTv = ((double)15 / 100) * costTv;
            }
            else
            {
                discountTv = costTv * 0;
            }

            if (costDvd > 5000 && costDvd < 10000)
            {
                discountDvd = ((double)10 / 100) * costDvd;
            }
            else if (costDvd >= 10000)
            {
                discountDvd = ((double)15 / 100) * costDvd;
            }
            else
            {
                discountDvd = costDvd * 0;
            }

            double totalDiscount = discountTv + discountDvd;
            double totalCost = costTv + costDvd + costMp3;

            double finalPrise = totalCost - totalDiscount;

            return finalPrise;
        }
    }
}