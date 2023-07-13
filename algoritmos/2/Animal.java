public class Animal {
    private double peso;
    private int patas;

    public Animal(double peso, int patas) {
        this.peso = peso;
        this.patas = patas;
    }

    public void andar() {
        System.out.println("O animal está andando.");
    }

    public void comer() {
        System.out.println("O animal está comendo.");
    }

    public double getPeso() {
        return peso;
    }

    public int getPatas() {
        return patas;
    }
}

public class Mamifero extends Animal {
    public Mamifero(double peso, int patas) {
        super(peso, patas);
    }
}

public class Ave extends Animal {
    public Ave(double peso, int patas) {
        super(peso, patas);
    }
}

public class Cao extends Mamifero {
    public Cao(double peso, int patas) {
        super(peso, patas);
    }

    public void atacar() {
        System.out.println("Sou um cão e estou atacando.");
    }
}

public class Gato extends Mamifero {
    public Gato(double peso, int patas) {
        super(peso, patas);
    }
}

public class Elefante extends Mamifero {
    public Elefante(double peso, int patas) {
        super(peso, patas);
    }

    @Override
    public void comer() {
        System.out.println("Sou um elefante e estou comendo.");
    }
}

public class Cavalo extends Mamifero {
    public Cavalo(double peso, int patas) {
        super(peso, patas);
    }
}

public class Andorinha extends Ave implements Voo {
    public Andorinha(double peso, int patas) {
        super(peso, patas);
    }

    @Override
    public void voar() {
        System.out.println("Sou uma andorinha e estou voando.");
    }
}

public class Pato extends Ave implements Voo {
    public Pato(double peso, int patas) {
        super(peso, patas);
    }

    @Override
    public void voar() {
        System.out.println("Sou um pato e estou voando.");
    }
}

public class Galinha extends Ave {
    public Galinha(double peso, int patas) {
        super(peso, patas);
    }
}

public interface Voo {
    void voar();
}

public class Main {
    public static void main(String[] args) {
        Cao cao = new Cao(12, 4);
        Gato gato = new Gato(5, 4);
        Elefante elefante = new Elefante(1000, 4);
        Cavalo cavalo = new Cavalo(500, 4);
        Andorinha andorinha = new Andorinha(0.1, 2);
        Pato pato = new Pato(5, 2);
        Galinha galinha = new Galinha(4, 2);

        cao.andar();
        cao.comer();
        cao.atacar();

        elefante.comer();

        andorinha.andar();
        andorinha.comer();
        andorinha.voar();
    }
}