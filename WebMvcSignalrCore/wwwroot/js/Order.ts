class Order {
    private orderId: number;
    private orderDate: Date;
    private totalBill : number;
    private isFinished: boolean;
    private _foodOrders: FoodOrder[]; 

    /**
     * Create order object
     * @param foodOrders
     */
    createOrder(foodOrders: FoodOrder[]) : any {
        this.orderId = Math.random(); //at the moment random
        this.orderDate = new Date(); //current date
        this.isFinished = false;
        this._foodOrders = foodOrders;
    }
}