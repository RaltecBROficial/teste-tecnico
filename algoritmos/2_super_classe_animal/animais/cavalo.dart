import '../tipos/mamifero.dart';

class Cavalo extends Mamifero {
  String nome;
  String raca;

  Cavalo(this.nome, this.raca, String sexo, int idade, double peso,
      int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  void descricaoCavalo() {
    print(
        'Cavalo nome: $nome, raça: $raca, sexo: $sexo, idade: $idade, peso: $peso, quantidade de patas: $quantidadeDePatas');
  }
}
