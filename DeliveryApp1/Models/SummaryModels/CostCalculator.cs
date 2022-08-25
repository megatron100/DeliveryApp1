using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryApp1
{
    public class CostCalculator
    {

        private static int GetDistance(string pickupAddress, string receiverAddress)
        {
            return 100;

        }

        /// <summary>
        /// 
        /// Get Cost of Delivery
        /// </summary>
        /// <param name="weight">Accepts weight in KG</param>
        /// <param name="pickupAddress">Full Address of Sender</param>
        /// <param name="receiverAddress">Full Address of Receiver</param>
        /// <returns>Return Cost of Delivery charge in Decimal Based on Weight and distance</returns>
        public static int GetCost(int item, int weight, string pickupAddress, string receiverAddress)
        {
            //int multiplier = 0;

            //int distance = GetDistance(pickupAddress, receiverAddress);
            //if (distance < 100) { multiplier = 20; }
            //else if (distance < 500) { multiplier = 50; }
            //else if (distance > 500) { multiplier = 100; }

            //return multiplier * weight;

            return item * weight;

        }

    }
}