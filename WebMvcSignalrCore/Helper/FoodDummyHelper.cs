using System;
using System.Collections.Generic;
using FoodOrderSignalrCore.Models;

namespace FoodOrderSignalrCore.Helper
{
    /// <summary>
    /// A temporary class that create dummy orders
    /// </summary>
    public static class FoodDummyHelper
    {
        public static Order CreateDummyOrder(int orderId = 1)
        {
            var foodOrder = new FoodOrder
            {
                OrderId = orderId,
                FoodOrderId = 1,
                Status = FoodStatus.FinishCooking,
                Food = new Food { Category = "Spicy Food", FoodId = 1, Name = "FriedRice" }
            };

            var foodOrder2 = new FoodOrder
            {
                OrderId = orderId,
                FoodOrderId = 2,
                Status = FoodStatus.InProgress,
                Food = new Food { Category = "Indonesian Food", FoodId = 1, Name = "Satay" }
            };

            var foodOrder3 = new FoodOrder
            {
                OrderId = orderId,
                FoodOrderId = 3,
                Status = FoodStatus.WaitingList,
                Food = new Food { Category = "Chinese Food", FoodId = 3, Name = "Capjay" }
            };

            var foodOrder4 = new FoodOrder
            {
                OrderId = orderId,
                FoodOrderId = 4,
                Status = FoodStatus.Delivered,
                Food = new Food { Category = "Dessert", FoodId = 4, Name = "Ice Cream" }
            };

            return new Order
            {
                OrderId = orderId,
                OrderDate = DateTime.Now,
                FoodOrders = new List<FoodOrder> { foodOrder, foodOrder2, foodOrder3, foodOrder4 }
            };
        }
    }
}
