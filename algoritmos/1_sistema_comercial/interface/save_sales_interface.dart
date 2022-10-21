import '../entities/products_entitie.dart';

abstract class SaveSaleLogsInterface {
  Future<void> saveSalesLogs(List<Products> products);
}
