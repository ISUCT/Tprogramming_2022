import { Cake } from "../src/classes/cake";
import { Steak } from "../src/classes/steak";

describe('Access Method Get', () => {
    it('name', () => {
        const name = "Cakee";
        const price = 200;
        const cake = new Cake(name, price);

        expect(cake.Name).toEqual(name);
    });

    it('price', () => {
        const name = "Steakk";
        const price = 499;
        const steak = new Steak(name, price);
        
        expect(steak.Price).toEqual(price);
    });

    it('ingrediens', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 3;
        const steak = new Steak(name, price, ingrediens);

        expect(steak.Ingrediens).toEqual(ingrediens);
    });

    it('description', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 3;
        const description = "This is a test description";
        const steak = new Steak(name, price, ingrediens, description);

        expect(steak.Description).toEqual(description);
    });
});

describe('Access Method Set', () => {
    it('name', () => {
        let name = "Cakee";
        const price = 200;
        const cake = new Cake(name, price);
        name = "ULTRA CAKE"
        cake.Name = name;

        expect(cake.Name).toEqual(name);
    });

    it('price', () => {
        const name = "Steakk";
        let price = 499;
        const steak = new Steak(name, price);
        price = 200;
        steak.Price = price;
        
        expect(steak.Price).toEqual(price);
    });

    it('ingrediens', () => {
        const name = "Steakk";
        const price = 499;
        let ingrediens = 3;
        const steak = new Steak(name, price, ingrediens);
        ingrediens = 4;
        steak.Ingrediens = ingrediens;

        expect(steak.Ingrediens).toEqual(ingrediens);
    });

    it('description', () => {
        const name = "Steakk";
        const price = 499;
        const ingrediens = 3;
        let description = "This is a test description";
        const steak = new Steak(name, price, ingrediens, description);
        description = "This is a teeest description";
        steak.Description = description;

        expect(steak.Description).toEqual(description);
    });
});