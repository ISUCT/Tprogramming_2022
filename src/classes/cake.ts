import { Dish } from "../dish";

export class Cake extends Dish {
    constructor(nameOfDish: string, price: number, ingrediens?: number, description?: string) {
        super(nameOfDish, price, ingrediens, description);
    }

    getMethodCooking(): string {
        return `Cake is cooking!`;
    }

    getCakeInfo(): string {
        return `Cake (name: ${this.nameOfDish} price: ${this.price} ingrediens: ${this.ingrediens} description: ${this.description})`;
    }

    methodCooking(): void {
        const cook = this.getMethodCooking();
        console.log(cook);
    }

    toString(): void {
        const info = this.getCakeInfo();
        console.log(info);
    }
}