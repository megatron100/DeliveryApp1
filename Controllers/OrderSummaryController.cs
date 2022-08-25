using DeliveryApp1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryApp1.Controllers
{
    public class OrderSummaryController : Controller
    {
        // GET: OrderSummary
        public ActionResult NewOrder(string id)
        {

            OrderDetailModel model = new OrderDetailModel()
            {
                OrderId = 1,
                ItemCount = 100

            };

            return View(model);
        }

        public ActionResult Summary(string orderId)

        {
            OrderDetailModel order = new OrderDetailModel();
            //{
            //Hardcoding for now
            order.OrderId = 1;
            order.ItemCount = 100;
            order.OrderWeight = 11;
            order.Cost = order.Getcost;

            //DataRow dr = DbHandler.GetInstance().GetOrderSummary(Convert.ToInt32(orderId));
            //OrderDetailModel order = new OrderDetailModel()
            //{
            //    ItemCount = Convert.ToInt32(dr[1]),
            //    OrderWeight = Convert.ToInt32(dr[2]),
            //    ReceiverAddress = Convert.ToString(dr[3]),
            //    PickupAddress = Convert.ToString(dr[4]),
            //    isPaymentDone = Convert.ToInt32(dr[5]) > 0 ? true : false,

            //};
            //Update Cost to Database
            //order.Cost = order.Getcost;
            // DbHandler.GetInstance().UpdateCost(Convert.ToInt32(orderId), order.Cost);

            return View(order);
        }

        [HttpGet]
        public ActionResult Payment(int id)
        {
            //  int amount = Dbhandler.getInstance().GetAmountbyId(id);
            PaymentModel payment = new PaymentModel()
            {
                Amount = id,
                OrderId = "ID500"

            };
            return View(payment);
        }

    }
}