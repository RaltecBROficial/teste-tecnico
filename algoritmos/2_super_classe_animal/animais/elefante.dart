import '../tipos/mamifero.dart';

class Elefante extends Mamifero {
  Elefante(String sexo, int idade, double peso, int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  @override
  void comer() {
    super.comer();
    print('elefante!');
  }
}
