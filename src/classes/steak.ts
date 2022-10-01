import { Dish } from "../dish";

export class Steak extends Dish {
    constructor(nameOfDish: string, price: number, ingrediens?: number, description?: string) {
        super(nameOfDish, price, ingrediens, description);
    }

    getMethodCooking(): string {
        return `Steak is cooking!`;
    }

    getSteakInfo(): string {
        return `Steak (name: ${this.nameOfDish} price: ${this.price} ingrediens: ${this.ingrediens} description: ${this.description})`;
    }

    methodCooking(): void {
        const cook = this.getMethodCooking();
        console.log(cook);
    }

    toString(): void {
        const info = this.getSteakInfo();
        console.log(info);
    }
}