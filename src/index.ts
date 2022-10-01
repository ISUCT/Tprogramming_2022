import { Cake } from "./classes/cake";
import { Steak } from "./classes/steak";
import { Dish } from "./dish";

const cake = new Cake("cake", 100);
cake.displayInformation()
cake.orderDish();
cake.Price = 200;
cake.displayInformation();
cake.toString();

const steak = new Steak("steak", 600, 1, "The best steak ever");
steak.displayInformation();
steak.Name = "Steak!!!";
steak.orderDish();
steak.toString();

const array: Dish[] = [cake, steak];
array.forEach((value) => value.methodCooking());
