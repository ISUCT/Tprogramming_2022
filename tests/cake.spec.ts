import { Cake } from "../src/classes/cake";

describe('Cake', () => {
    it('get cake method cooking', () => {
        const name = "Cakee";
        const price = 300;
        const ingrediens = 3;
        const description = "This is a usually cake";
        const cake = new Cake(name, price, ingrediens, description);
        
        const information = `Cake is cooking!`;

        expect(cake.getMethodCooking()).toEqual(information);
    });

    it('get cake info', () => {
        const name = "Cakeee";
        const price = 499;
        const ingrediens = 1;
        const description = "This is a usually cake";
        const cake = new Cake(name, price, ingrediens, description);

        const info = `Cake (name: ${name} price: ${price} ingrediens: ${ingrediens} description: ${description})`;

        expect(cake.getCakeInfo()).toEqual(info);
    });
});