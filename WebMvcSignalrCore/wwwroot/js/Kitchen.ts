class Kitchen {
    public foodOrders: FoodOrder[];

    constructor() {
        this.foodOrders = new Array<FoodOrder>();
    }

    addOrder(fo: FoodOrder): void {
        this.foodOrders.push(fo);
    }

    refreshKitchens(fOrders: FoodOrder[]) {
        this.foodOrders = fOrders;
    }
}