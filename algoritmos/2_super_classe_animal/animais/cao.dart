import '../tipos/mamifero.dart';

class Cao extends Mamifero {
  String nome;
  String raca;

  Cao(this.nome, this.raca, String sexo, int idade, double peso,
      int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  void atacar() {
    print('Os cachorros atacam!');
  }
}
