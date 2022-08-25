using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryApp1.Models
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public string OrderId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}