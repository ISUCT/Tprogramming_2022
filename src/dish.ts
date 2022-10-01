export abstract class Dish {
    protected price: number;
    protected ingrediens: number;
    protected nameOfDish: string;
    protected description: string;

    constructor(nameOfDish: string, price: number, ingrediens?: number,  
    description?: string) {
        this.Name = nameOfDish;
        this.Price = price;

        if (ingrediens) {
            this.Ingrediens = ingrediens
        } else {
            this.Ingrediens = 1;
        }

        if (description) {
            this.Description = description;
        } else {
            this.Description = "UNDEFINED!!!";
        }
    }

    get Name(): string {
        return this.nameOfDish;
    }

    set Name(name: string) {
        if (name.length <= 2) {
            throw new Error();
        }

        this.nameOfDish = name;
    }

    get Price(): number {
        return this.price;
    }

    set Price(price: number) {
        if (price == 0) {
            throw new Error();
        }

        this.price = price;
    }

    get Ingrediens(): number {
        return this.ingrediens;
    }

    set Ingrediens(ingrediens: number) {
        if (ingrediens == 0) {
            throw new Error();
        }

        this.ingrediens = ingrediens;
    }

    get Description(): string {
        return this.description;
    }

    set Description(description: string) {
        if (description.length < 10) {
            throw new Error();
        }

        this.description = description;
    }

    abstract methodCooking(): void;

    getInformation(): string {
        return `Dish\nName: ${this.nameOfDish}\nPrice: ${this.price}\nDescription: ${this.description}\nIngrediens: ${this.ingrediens}`;
    }

    displayInformation(): void {
        const information = this.getInformation();
        console.log(information);
    }

    getOrderDish(): string {
        return `Your Dish is ${this.nameOfDish}`;
    }

    orderDish(): void {
        const dish = this.getOrderDish(); 
        console.log(dish);
    }
}