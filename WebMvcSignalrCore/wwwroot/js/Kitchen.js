var Kitchen = /** @class */ (function () {
    function Kitchen() {
        this.foodOrders = new Array();
    }
    Kitchen.prototype.addOrder = function (fo) {
        this.foodOrders.push(fo);
    };
    Kitchen.prototype.refreshKitchens = function (fOrders) {
        this.foodOrders = fOrders;
    };
    return Kitchen;
}());
//# sourceMappingURL=Kitchen.js.map