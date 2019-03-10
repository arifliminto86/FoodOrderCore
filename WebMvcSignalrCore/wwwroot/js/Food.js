var Food = /** @class */ (function () {
    function Food() {
    }
    Object.defineProperty(Food.prototype, "name", {
        get: function () {
            return this._name;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Food.prototype, "category", {
        get: function () {
            return this._category;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Food.prototype, "price", {
        get: function () {
            return this._price;
        },
        enumerable: true,
        configurable: true
    });
    Food.prototype.setFood = function (name, category, price) {
        this._name = name;
        this._category = category;
        this._price = price;
    };
    return Food;
}());
//# sourceMappingURL=Food.js.map