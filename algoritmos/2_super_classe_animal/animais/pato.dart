import '../interfaces/acao_animal_interface.dart';
import '../tipos/ave.dart';

class Pato extends Ave implements AcaoAnimalInterface {
  String cor;

  Pato(this.cor, String sexo, int idade, double peso, int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  @override
  void voar() {
    print('Os patos voam!');
  }
}
