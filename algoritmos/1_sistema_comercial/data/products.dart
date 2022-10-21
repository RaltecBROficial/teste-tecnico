import 'dart:math';

import '../entities/products_entitie.dart';

final listProducts = [
  Products(
    id: Random().nextInt(9999),
    name: 'Caderno',
    unitaryValue: 14.42,
    quantity: 10,
  ),
  Products(
    id: Random().nextInt(9999),
    name: 'Lapis',
    unitaryValue: 3.5,
    quantity: 11,
  ),
  Products(
    id: Random().nextInt(9999),
    name: 'Borracha',
    unitaryValue: 5,
    quantity: 23,
  ),
  Products(
    id: Random().nextInt(9999),
    name: 'Kit Lapis',
    unitaryValue: 30.8,
    quantity: 34,
  ),
  Products(
    id: Random().nextInt(9999),
    name: 'Tablet',
    unitaryValue: 750.2,
    quantity: 8,
  ),
  Products(
    id: Random().nextInt(9999),
    name: 'Bloco de Anotacao',
    unitaryValue: 8.35,
    quantity: 30,
  ),
];
