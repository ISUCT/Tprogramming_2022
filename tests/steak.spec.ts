import { Steak } from "../src/classes/steak";

describe('Steak', () => {
    it('get steak method cooking', () => {
        const name = "Steak";
        const price = 300;
        const ingrediens = 3;
        const description = "This is a usually steak";
        const steak = new Steak(name, price, ingrediens, description);
        
        const information = `Steak is cooking!`;

        expect(steak.getMethodCooking()).toEqual(information);
    });

    it('get steak info', () => {
        const name = "Steak";
        const price = 499;
        const ingrediens = 1;
        const description = "This is a usually steak";
        const steak = new Steak(name, price, ingrediens, description);

        const info = `Steak (name: ${name} price: ${price} ingrediens: ${ingrediens} description: ${description})`;

        expect(steak.getSteakInfo()).toEqual(info);
    });
});