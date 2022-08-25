using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeliveryApp1.Models;

namespace DeliveryApp1
{
    public static class cacher
    {
        private static OrderDetailModel orderModel;
        private static PaymentModel paymentModel;
        public static OrderDetailModel getOrderCache()
        {
            return orderModel;
        }
        public static void setOrderCache(OrderDetailModel model)
        {
            orderModel = model;
        }

        public static PaymentModel getPaymentCache()
        {
            return paymentModel;
        }
        public static void setPaymentCache(PaymentModel model)
        {
            paymentModel = model;
        }

    }

}