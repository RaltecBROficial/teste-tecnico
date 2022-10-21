import '../interface/discount_quantity_interface.dart';

class DiscountQuantity implements DiscountQuantityInterface {
  double totalValue = 0;

  @override
  double discountQuantity(int quantity, double unitaryValue) {
    final calc = (unitaryValue * quantity);
    totalValue = calc;

    if (quantity > 10 && quantity <= 20) {
      // print('5% desconto\n');
      return calc * .95;
    } else if (quantity > 20 && quantity <= 30) {
      // print('10% desconto\n');
      return calc * .9;
    } else if (quantity > 30) {
      // print('20% desconto\n');
      return calc * .8;
    } else {
      // print('sem desconto\n');
      return calc;
    }
  }
}
