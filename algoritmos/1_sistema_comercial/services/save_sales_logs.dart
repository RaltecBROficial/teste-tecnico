import 'dart:math';

import '../entities/products_entitie.dart';
import '../entities/sales_items.dart';
import '../entities/sales_registration_entitie.dart';
import '../interface/save_sales_interface.dart';
import 'discount_quantity.dart';

class SaveSalesLogs implements SaveSaleLogsInterface {
  DiscountQuantity discountQuantity = DiscountQuantity();

  @override
  Future<void> saveSalesLogs(List<Products> products) async {
    final DateTime date = DateTime.now();
    final List<SalesRegistration> salesRegistration = [];

    print('Venda Realizada\n');

    for (var p in products) {
      salesRegistration.add(
        SalesRegistration(
          salesNumber: Random().nextInt(9999),
          dateTime: date,
          salesItems: SalesItems(
            produto: p.name,
            quantity: p.quantity,
            totalValue:
                discountQuantity.discountQuantity(p.quantity, p.unitaryValue),
          ),
        ),
      );
    }

    print('');

    for (var e in salesRegistration) {
      print('Nº de venda: ${e.salesNumber}');
      print('Data e hora da compra: ${e.dateTime}');
      print('Nome do produto: ${e.salesItems.produto}');
      print('Quantidade: ${e.salesItems.quantity}');
      print('Valor total: ${e.salesItems.totalValue.toStringAsFixed(2)}');
      print('');
    }
  }
}
