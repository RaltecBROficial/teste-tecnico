import 'animais.dart';

abstract class Ave extends Animal {
  String sexo;
  int idade;

  Ave(this.sexo, this.idade, double peso, int quantidadeDePatas)
      : super(peso, quantidadeDePatas);
}
