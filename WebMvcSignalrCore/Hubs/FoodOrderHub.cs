using System.Threading.Tasks;
using FoodOrderSignalrCore.Helper;
using FoodOrderSignalrCore.Models;
using Microsoft.AspNetCore.SignalR;

namespace WebMvcSignalrCore.Hubs
{
    public class FoodOrderHub : Hub
    {
        private const string KitchenGroup = "Kitchen";
        private const string WaitressGroup = "Waitress";

        public async Task OrderFood(Order order)
        {
            order = FoodDummyHelper.CreateDummyOrder(1);
            await Clients.Group(KitchenGroup).SendAsync("ReceiveMessage", "Notifications", "Order is coming");
            await Clients.Group(KitchenGroup).SendAsync("ReceiveFoodOrder", order);
        }

        public async Task CallWaitressToDeliverFood(FoodOrder order)
        {
            await Clients.Group(WaitressGroup).SendAsync("DeliverFood", order);
        }

        public async Task JoinRoom(string user, string roomName)
        {
            await Groups.AddToGroupAsync(this.Context.ConnectionId, roomName);
            await Clients.All.SendAsync("ReceiveMessage", user, $"{user} connected to room {roomName}");
        }

        public async Task LeaveRoom(string user, string roomName)
        {
            await Groups.RemoveFromGroupAsync(this.Context.ConnectionId, roomName);
            await Clients.All.SendAsync("ReceiveMessage", user, $"{user} leaved the room {roomName}");
        }

        public async Task SendMessage( string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendServerMessage(string user, string message)
        {
            Food food = new Food{Category = "Animal", Name = "cat food"};
            await Clients.All.SendAsync("ReceiveServerMessage", food);
        }

        /// <summary>
        /// Update food status for kitchen and waitress
        /// if food status is ready to deliver then we update waitress ui to show food that ready to deliver
        /// </summary>
        /// <param name="foodOrder"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task UpdateFoodStatus(FoodOrder foodOrder, FoodStatus status)
        {
            foodOrder.Status = status;
            await Clients.Groups(KitchenGroup).SendAsync("refreshKitchen", foodOrder);

            //Notify the waitress to pick up the order
            if (status == FoodStatus.Delivered)
            {
                await Clients.Groups(WaitressGroup).SendAsync("deliverFood", foodOrder);
            }
        }
    }
}