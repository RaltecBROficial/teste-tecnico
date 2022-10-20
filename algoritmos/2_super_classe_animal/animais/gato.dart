import '../tipos/mamifero.dart';

class Gato extends Mamifero {
  String nome;

  Gato(this.nome, String sexo, int idade, double peso,
      int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  void acao() {
    print('O gato mia!');
  }
}
