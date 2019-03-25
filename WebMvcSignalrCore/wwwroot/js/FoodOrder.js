var FoodOrder = /** @class */ (function () {
    function FoodOrder() {
    }
    FoodOrder.prototype.setFoodOrder = function (orderId, foodOrderId, food, status) {
        this.orderId = orderId;
        this.foodOrderId = foodOrderId;
        this.food = food;
        this.status = status;
    };
    /**
     * Create html card
     * @param divId
     */
    FoodOrder.prototype.createCard = function (divId) {
        var buttonId = "btn_" + this.foodOrderId;
        var htmlstr = "<div class='card' style='width: 18rem;' id='" + divId + "'>" +
            "<div class='card-header'>" + this.orderId + ": " + this.food.name + "</div>" +
            "<div class='card-body text-center'>" +
            "<p class='card-text'>" +
            "Category:" + this.food.category + "</br>" +
            "Status:" + this.status +
            "</p>" +
            "<input id='" + buttonId + "' type='button' class='btn btn-dark' value='Next' " +
            "onClick= updateStatus('" + this.foodOrderId + "') />" +
            "</div>" +
            "</div>" +
            "<div class='row'></div>";
        return htmlstr;
    };
    return FoodOrder;
}());
//# sourceMappingURL=FoodOrder.js.map