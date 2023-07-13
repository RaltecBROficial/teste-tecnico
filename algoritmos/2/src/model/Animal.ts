export abstract class Animal {
    private peso: number;
    private qtdPatas: number;

    constructor(peso: number, qtdPatas: number) {
        this.peso = peso;
        this.qtdPatas = qtdPatas;
    }


    andar() {
        console.log(`${this.constructor.name} andando...`);
    }

    comer() {
        console.log(`${this.constructor.name} comendo...`);
    }
}
