using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryApp1.Models
{
    public class OrderDetailModel
    {
        public int OrderId { get; set; }

        public int ItemCount { get; set; }

        public int OrderWeight { get; set; }

        public string ReceiverAddress { get; set; }
        public string PickupAddress { get; set; }

        public int Cost { get; set; }

        public bool? isPaymentDone { get; set; }

        public int Getcost
        {
            get
            {

                return CostCalculator.GetCost(ItemCount, OrderWeight, PickupAddress, ReceiverAddress);

            }
            private set { }

        }
    }
}