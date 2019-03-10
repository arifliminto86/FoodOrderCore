var FoodOrderClass = /** @class */ (function () {
    function FoodOrderClass() {
    }
    /**
     * Create html card
     * @param divId
     */
    FoodOrderClass.prototype.createCard = function (divId) {
        var htmlstr = "<div class='card' style='width: 18rem;' id='" + divId + "'>" +
            "<div class='card-header'>" + this._orderId + ": " + this._food.name + "</div>" +
            "<div class='card-body text-center'>" +
            "<p class='card-text'>" +
            "Category:" + this._food.category + "</br>" +
            "Status:" + this._status +
            "</p>" +
            "</div>" +
            "</div>" +
            "<div class='row'></div>";
        return htmlstr;
    };
    return FoodOrderClass;
}());
//# sourceMappingURL=FoodOrderClass.js.map