import { Andorinha } from "./model/Andorinha";
import { Cao } from "./model/Cao";
import { Cavalo } from "./model/Cavalo";
import { Elefante } from "./model/Elefante";
import { Galinha } from "./model/Galinha";
import { Gato } from "./model/Gato";
import { Pato } from "./model/Pato";

function main(){

    const elefante = new Elefante(1000, 4);
    const andorinha = new Andorinha(0.1, 2);
    const cao = new Cao(10, 4);
    const cavalo = new Cavalo(100, 4);
    const galinha = new Galinha(1, 2);
    const gato = new Gato(5, 4);
    const pato = new Pato(2, 2);

    const animais = [elefante, andorinha, cao, cavalo, galinha, gato, pato];
    animais.forEach(animal => {
        console.log(`\n${animal.constructor.name}`);
        animal.comer();
        animal.andar();
        if(animal instanceof Andorinha || animal instanceof Pato)
            animal.voar();
        
        if(animal instanceof Cao)
            animal.atacar();
        console.log("=====================================");
    });
}

main();