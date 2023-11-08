// Interface para animais que podem voar
interface Voador {
    voar(): void;
  }

  // Classe base para todos os animais
  class Animal {
    constructor(public peso: number, public patas: number) {}

    andar() {
      console.log(`Estou andando com ${this.patas} patas.`);
    }

    comer() {
      console.log(`Estou comendo.`);
    }
  }

  // Classe base para mamíferos
  class Mamifero extends Animal {
    constructor(peso: number, patas: number) {
      super(peso, patas);
    }
  }

  // Classe base para aves
  class Ave extends Animal {
    constructor(peso: number, patas: number) {
      super(peso, patas);
    }
  }

  // Subclasses de Mamifero
  class Cao extends Mamifero {
    atacar() {
      console.log(`Sou um cão e estou atacando.`);
    }
  }

  class Gato extends Mamifero {}

  class Elefante extends Mamifero {
    comer() {
      console.log(`Sou um elefante e estou comendo com a tromba.`);
    }
  }

  class Cavalo extends Mamifero {}

  // Subclasses de Ave
  class Andorinha extends Ave implements Voador {
    voar() {
      console.log(`Sou uma andorinha e estou voando.`);
    }
  }

  class Pato extends Ave implements Voador {
    voar() {
      console.log(`Sou um pato e estou voando.`);
    }
  }

  class Galinha extends Ave {}

  // Exemplo de uso
  const cao = new Cao(10, 4);
  cao.atacar();
  cao.comer();
  cao.andar();

  const elefante = new Elefante(1000, 4);
  elefante.comer();

  const andorinha = new Andorinha(0.1, 2);
  andorinha.comer();
  andorinha.andar();
  andorinha.voar();
