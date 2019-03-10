using System.ComponentModel;
using FoodOrderSignalrCore.Helper;

namespace FoodOrderSignalrCore.Models
{
    public sealed class FoodOrder
    {
        public int FoodOrderId { get; set; }
        public Food Food { get; set; }
        public long OrderId { get; set; }

        public FoodStatus Status { get; set; }

        public string StatusStr => EnumerationHelper.GetEnumDescription((FoodStatus)Status);
    }

    public enum FoodStatus
    {
        [Description("Waiting List")]
        WaitingList,

        [Description("In Progress")]
        InProgress,

        [Description("Finish Cooking")]
        FinishCooking,

        [Description("Delivered")]
        Delivered
    }
}
