// Classe Animal (superclasse)
class Animal {
  constructor(peso, patas) {
    this.peso = peso;
    this.patas = patas;
  }

  andar() {
    console.log(`Sou um animal e estou andando com ${this.patas} patas.`);
  }

  comer() {
    console.log("Sou um animal e estou comendo.");
  }
}

// Classe Mamifero (subclasse de Animal)
class Mamifero extends Animal {
  constructor(peso, patas) {
    super(peso, patas);
  }

  comer() {
    console.log("Sou um mamífero e estou mamando.");
  }
}

// Classe Ave (subclasse de Animal)
class Ave extends Animal {
  constructor(peso, patas) {
    super(peso, patas);
  }

  voar() {
    console.log("Sou uma ave e estou voando.");
  }
}

// Subclasses de Mamifero
class Cao extends Mamifero {
  atacar() {
    console.log("Sou um cão e estou atacando.");
  }
}

class Gato extends Mamifero {}

class Elefante extends Mamifero {
  comer() {
    console.log("Sou um elefante e estou comendo com minha tromba.");
  }
}

class Cavalo extends Mamifero {}

// Subclasses de Ave
class Andorinha extends Ave {
  voar() {
    console.log("Sou uma andorinha e estou voando alto.");
  }
}

class Pato extends Ave {
  voar() {
    console.log("Sou um pato e estou voando baixo.");
  }
}

class Galinha extends Ave {}

// Exemplos de uso
const cao = new Cao(10, 4);
const elefante = new Elefante(5000, 4);
const andorinha = new Andorinha(0.02, 2);

cao.atacar();
elefante.comer();
andorinha.voar();
