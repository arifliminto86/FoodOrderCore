class Food {
    private _name: string;
    private _category: string;
    private _price: number;

    public get name() {
         return this._name;
    } 
    public get category() {
        return this._category;
    }

    public get price() {
        return this._price;
    }

    public setFood(name: string, category: string, price: number) {
        this._name = name;
        this._category = category;
        this._price = price;
    }
}