import 'sales_items.dart';

class SalesRegistration {
  final int salesNumber;
  final DateTime dateTime;
  final SalesItems salesItems;

  SalesRegistration({
    required this.salesNumber,
    required this.dateTime,
    required this.salesItems,
  });
}
