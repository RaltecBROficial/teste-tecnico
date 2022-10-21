import 'package:flutter/cupertino.dart';
import 'package:get/get.dart';
import '../model/product.dart';
import '../view/screen/cart_screen.dart';

class ProductController extends GetxController {
  RxList<Product> allProducts = productList.obs;
  bool isItemListScreen = true;
  bool isCartScreen = false;
  Rx<int> itemCount = 0.obs;
  Rx<double> price = 0.0.obs;

  Widget navigateToCartScreen(BuildContext context) {
    isCartScreen = true;
    isItemListScreen = false;
    calculatePrice();
    return const CartScreen();
  }

  countAllItems() {
    itemCount.value = 0;
    for (var element in allProducts) {
      itemCount.value += element.count;
    }
  }

  calculatePrice() {
    price.value = 0.0;

    for (var element in allProducts) {
      if (element.count > 0 && element.count < 10) {
        price.value = (double.parse(element.price.replaceAll("\$", "").trim()) *
            element.count);
      } else if (element.count >= 10 && element.count < 20) {
        double calculo =
            (double.parse(element.price.replaceAll("\$", "").trim()) *
                element.count);
        double porcentagem = (5 * calculo) / 100;
        price.value = calculo - porcentagem;
      } else if (element.count >= 20 && element.count < 30) {
        double calculo =
            (double.parse(element.price.replaceAll("\$", "").trim()) *
                element.count);
        double porcentagem = (10 * calculo) / 100;
        price.value = calculo - porcentagem;
      } else if (element.count >= 30) {
        double calculo =
            (double.parse(element.price.replaceAll("\$", "").trim()) *
                element.count);
        double porcentagem = (20 * calculo) / 100;
        price.value = calculo - porcentagem;
      }
    }
  }

  Future<bool> navigateToListItemScreen() async {
    controller.isCartScreen = false;
    controller.isItemListScreen = true;
    return true;
  }

  void increase(int index) {
    allProducts[index].count++;
    allProducts.refresh();
    countAllItems();
    calculatePrice();
  }

  void decrease(int index) {
    if (allProducts[index].count > 0) {
      allProducts[index].count--;
      allProducts.refresh();
      countAllItems();
      calculatePrice();
    }
  }

  void removeItems() {
    for (var item in allProducts) {
      item.count = 0;
    }
    allProducts.refresh();
    itemCount.value = 0;
    calculatePrice();
  }

  VoidCallback? isCheckOutButtonEnabled() {
    if (itemCount > 0) return () {};
    return null;
  }
}
