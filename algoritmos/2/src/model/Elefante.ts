import { Mamifero } from "./Mamifero";

export class Elefante extends Mamifero {

    override comer(): void {
        console.log("Elefante comendo...");
    }
}