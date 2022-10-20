import 'animais/andorinha.dart';
import 'animais/cao.dart';
import 'animais/cavalo.dart';
import 'animais/elefante.dart';
import 'animais/galinha.dart';
import 'animais/gato.dart';
import 'animais/pato.dart';

void main() {
  //Mamiferos
  Elefante elefante = Elefante('Macho', 15, 3000, 4);
  print(
      'Elefante: Sexo: ${elefante.sexo} Idade: ${elefante.idade} Peso: ${elefante.peso} Quantidade de Patas: ${elefante.quantidadeDePatas}');
  elefante
    ..andar()
    ..comer();

  print('');

  Cao cao = Cao('Pitoco', 'Husky', 'Macho', 2, 35, 4);
  print(
      'Cao: Nome: ${cao.nome} Raça: ${cao.raca} Sexo: ${cao.sexo} Idade: ${cao.idade} Peso: ${cao.peso} Quantidade de Patas: ${cao.quantidadeDePatas}');
  cao
    ..andar()
    ..comer()
    ..atacar();

  print('');

  Gato gato = Gato('Nika', 'Femea', 5, 8, 4);
  print(
      'Gato: Nome: ${gato.nome} Sexo: ${gato.sexo} Idade: ${gato.idade} Peso: ${gato.peso} Quantidade de Patas: ${gato.quantidadeDePatas}');
  gato
    ..andar()
    ..comer()
    ..acao();

  print('');

  Cavalo cavalo = Cavalo('Flecha', 'Quarto de Milha', 'Femea', 6, 500, 4);
  cavalo
    ..descricaoCavalo()
    ..andar()
    ..comer();

  //Aves
  print('');

  Andorinha andorinha = Andorinha('Azul', 'Macho', 1, 0.2, 2);
  print(
      'Andorinha: Cor: ${andorinha.cor} Sexo: ${andorinha.sexo} Idade: ${andorinha.idade} Peso: ${andorinha.peso} Quantidade de Patas: ${andorinha.quantidadeDePatas}');
  andorinha
    ..andar()
    ..comer()
    ..voar();

  print('');

  Pato pato = Pato('Marrom', 'Macho', 3, 1.5, 2);
  print(
      'Pato: Cor: ${pato.cor} Sexo: ${pato.sexo} Idade: ${pato.idade} Peso: ${pato.peso} Quantidade de Patas: ${pato.quantidadeDePatas}');
  pato
    ..andar()
    ..comer()
    ..voar();

  print('');

  Galinha galinha = Galinha('Marrom', 'Poedeira', 'Femea', 1, 2.5, 2);
  print(
      'Galinha: Cor: ${galinha.cor} Tipo: ${galinha.tipo} Sexo: ${galinha.sexo} Idade: ${galinha.idade} Peso: ${galinha.peso} Quantidade de Patas: ${galinha.quantidadeDePatas}');
  galinha
    ..andar()
    ..comer();
}
