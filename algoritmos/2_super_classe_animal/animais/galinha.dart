import '../tipos/ave.dart';

class Galinha extends Ave {
  String cor;
  String tipo;

  Galinha(this.cor, this.tipo, String sexo, int idade, double peso,
      int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);
}
