import { Cake } from "../src/classes/cake";
import { Steak } from "../src/classes/steak";

describe('Constructors', () => {
    it('all parameters', () => {
        const name = "Cakee";
        const price = 300;
        const ingrediens = 3;
        const description = "This is a usually cake";
        let condition = false;
        const cake = new Cake(name, price, ingrediens, description);
        
        if (name == cake.Name && price == cake.Price && ingrediens == cake.Ingrediens && description && cake.Description) {
            condition = true;
        }

        expect(condition).toBeTruthy();
    });

    it('three parameters', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 1;
        const description = "UNDEFINED!!!";
        let condition = false;
        const steak = new Steak(name, price, ingrediens);

        if (name == steak.Name && price == steak.Price && ingrediens == steak.Ingrediens && description && steak.Description) {
            condition = true;
        }

        expect(condition).toBeTruthy();
    });

    it('two parameters', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 1;
        const description = "UNDEFINED!!!";
        let condition = false;
        const steak = new Steak(name, price);

        if (name == steak.Name && price == steak.Price && ingrediens == steak.Ingrediens && description && steak.Description) {
            condition = true;
        }

        expect(condition).toBeTruthy();
    });
});