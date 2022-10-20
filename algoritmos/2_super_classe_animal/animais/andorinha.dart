import '../interfaces/acao_animal_interface.dart';
import '../tipos/ave.dart';

class Andorinha extends Ave implements AcaoAnimalInterface {
  String cor;

  Andorinha(
      this.cor, String sexo, int idade, double peso, int quantidadeDePatas)
      : super(sexo, idade, peso, quantidadeDePatas);

  @override
  void voar() {
    print('As andorinhas voam!');
  }
}
