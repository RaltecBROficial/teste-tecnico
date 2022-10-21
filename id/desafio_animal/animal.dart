void main() {
  Mamifero cachorro = new Mamifero(
    nome: 'Cachorro',
    patas: 4,
    peso: 12.45,
    canAttack: true,
  );
  Mamifero gato = new Mamifero(
    nome: 'Gato',
    patas: 4,
    peso: 12.45,
  );

  Mamifero elefante = new Mamifero(
    nome: 'Elefante',
    patas: 4,
    peso: 12.45,
    isElep: true,
  );
  Mamifero cavalo = new Mamifero(
    nome: 'Cavalo',
    patas: 4,
    peso: 12.45,
  );

  Ave andorinha = new Ave(
    nome: 'Andorinha',
    patas: 2,
    peso: 0.650,
  );
  Ave pato = new Ave(
    nome: 'Pato',
    patas: 2,
    peso: 6.7,
  );
  Ave galinha = new Ave(
    nome: 'Galinha',
    patas: 2,
    peso: 8.76,
  );

  print('${cachorro.nome} está ${cachorro.andando()}');
  print('${gato.nome} está ${gato.andando()}');
  print('${elefante.nome} está ${elefante.comendo()}');
  print('${cavalo.nome} está ${cavalo.comendo()}');
  print('${galinha.nome} está ${galinha.andando()}');
  print('${andorinha.nome} está ${andorinha.voando()}');
  print('${pato.nome} está ${pato.voando()}');
}

abstract class Animal {
  int patas;
  double peso;
  String andando();
  String comendo();

  Animal({
    required this.patas,
    required this.peso,
  });
}

class Mamifero extends Animal {
  String? nome;
  bool isElep;
  bool? canAttack;
  Mamifero({
    required super.patas,
    required super.peso,
    this.nome,
    this.isElep = false,
    this.canAttack = false,
  });

  @override
  andando() {
    return 'andando';
  }

  @override
  comendo() {
    if (isElep == false) {
      return 'comendo';
    } else {
      return 'comendo de uma forma diferente.';
    }
  }
}

class Ave extends Animal implements Voar {
  String? nome;
  Ave({
    required super.patas,
    required super.peso,
    this.nome,
  });

  @override
  voando() {
    return '..voando';
  }

  @override
  andando() {
    return 'andando';
  }

  @override
  comendo() {
    return 'comendo';
  }
}

abstract class Voar {
  String voando() {
    return '';
  }
}
