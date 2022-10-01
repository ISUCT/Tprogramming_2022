import { Cake } from "../src/classes/cake";
import { Steak } from "../src/classes/steak";

describe('Dish', () => {
    it('get information', () => {
        const name = "Cakee";
        const price = 300;
        const ingrediens = 3;
        const description = "This is a usually cake";
        const cake = new Cake(name, price, ingrediens, description);
        
        const information = `Dish\nName: ${name}\nPrice: ${price}\nDescription: ${description}\nIngrediens: ${ingrediens}`;

        expect(cake.getInformation()).toEqual(information);
    });

    it('get order', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 1;
        const steak = new Steak(name, price, ingrediens);

        const order = `Your Dish is ${name}`;

        expect(steak.getOrderDish()).toEqual(order);
    });
});