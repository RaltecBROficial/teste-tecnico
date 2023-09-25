class Animal {
    constructor(peso, qtPatas) {
        this.peso = peso;
        this.qtPatas = qtPatas;
    }

    andar() {}
    comer() {}
}

class Mamifero extends Animal {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
}

class Ave extends Animal {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
}

class Cao extends Mamifero {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    atacar() {}
    cao() {
        console.log("Sou um cão e estou comendo");
    }
}

class Gato extends Mamifero {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    gato() {
        console.log("Sou um gato e estou comendo");
    }
}

class Elefante extends Mamifero {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    comer() {}
    elefante() {
        console.log("Sou um elefante e estou comendo");
    }
}

class Cavalo extends Mamifero {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    cavalo() {
        console.log("Sou um cavalo e estou comendo");
    }
}

class Andorinha extends Ave {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    voar() {}
    andorinha() {
        console.log("Sou uma andorinha e estou comendo");
    }
}

class Pato extends Ave {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    voar() {}
    pato() {
        console.log("Sou um gato e estou comendo");
    }
}

class Galinha extends Ave {
    constructor(peso, qtPatas) {
        super(peso, qtPatas)
    }
    galinha() {
        console.log("Sou uma galinha e estou comendo");
    }
}

a = new Cao();
a.cao();

b = new Gato();
b.gato();

c = new Elefante();
c.elefante();

d = new Cavalo();
d.cavalo();

e = new Andorinha();
e.andorinha();

f = new Pato();
f.pato();

g = new Galinha();
g.galinha();

