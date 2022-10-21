import 'dart:math';

import 'entities/products_entitie.dart';
import 'services/save_sales_logs.dart';

void main() {
  print('01 - Sistemas de Vendas\n');
  final List<Products> product = [];
  SaveSalesLogs saveSales = SaveSalesLogs();

//Venda 01
  product.add(
    Products(
      id: Random().nextInt(9999),
      name: 'Tablet',
      unitaryValue: 750.41,
      quantity: 11,
    ),
  );

  //Venda 02
  product.add(
    Products(
      id: Random().nextInt(9999),
      name: 'Lapis de Cor',
      unitaryValue: 50.5,
      quantity: 25,
    ),
  );

  //Venda 03
  product.add(
    Products(
      id: Random().nextInt(9999),
      name: 'Cardeno de Estudos',
      unitaryValue: 32.9,
      quantity: 32,
    ),
  );

  //Venda 04
  product.add(
    Products(
      id: Random().nextInt(9999),
      name: 'Giz de Cera',
      unitaryValue: 5.2,
      quantity: 5,
    ),
  );

  //realizando o pedido dos produtos
  saveSales.saveSalesLogs(product);
}
