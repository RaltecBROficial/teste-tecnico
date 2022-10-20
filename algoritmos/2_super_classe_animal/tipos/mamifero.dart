import 'animais.dart';

abstract class Mamifero extends Animal {
  String sexo;
  int idade;

  Mamifero(this.sexo, this.idade, double peso, int quantidadeDePatas)
      : super(peso, quantidadeDePatas);

  @override
  void comer() {
    print('Se alimento como um');
  }
}
