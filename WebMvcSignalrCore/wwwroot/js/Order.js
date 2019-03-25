var Order = /** @class */ (function () {
    function Order() {
    }
    /**
     * Create order object
     * @param foodOrders
     */
    Order.prototype.createOrder = function (foodOrders) {
        this.orderId = Math.random(); //at the moment random
        this.orderDate = new Date(); //current date
        this.isFinished = false;
        this._foodOrders = foodOrders;
    };
    return Order;
}());
//# sourceMappingURL=Order.js.map