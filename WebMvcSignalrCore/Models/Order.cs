using System;
using System.Collections.Generic;

namespace FoodOrderSignalrCore.Models
{
    public sealed class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<FoodOrder> FoodOrders { get; set; }

        public int TotalBill => CalculateTotalPrice();

        /// <summary>
        /// status to indicate if all the food order is delivered to customer.
        /// </summary>
        public bool IsFinished => IsOrderFinished();

        bool IsOrderFinished()
        {
            var isFinished = true;
            foreach (var fo in FoodOrders)
            {
                if (fo.Status != FoodStatus.Delivered)
                {
                    isFinished = false;
                    break;
                }
            }

            return isFinished;
        }

        int CalculateTotalPrice()
        {
            int totalPrice = 0;
            foreach (var fo in FoodOrders)
            {
                totalPrice += fo.Food.Price;
            }

            return totalPrice;
        }

    }
}
