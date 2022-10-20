// ignore_for_file: public_member_api_docs, sort_constructors_first
abstract class Animal {
  double peso;
  int quantidadeDePatas;

  Animal(this.peso, this.quantidadeDePatas);

  void comer() {
    print('Todos os animais comem!');
  }

  void andar() {
    print('Todos os animais andam!');
  }
}
