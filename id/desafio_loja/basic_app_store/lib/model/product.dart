class Product {
  String name;
  String price;
  int count;
  String image;

  Product(
    this.name,
    this.price,
    this.count,
    this.image,
  );
}

List<Product> productList = [
  Product(
    'Pudge Dota 2',
    "100\$",
    0,
    'asset/images/product1.jpg',
  ),
  Product(
    'Draven LoL',
    "200\$",
    0,
    'asset/images/product2.jpg',
  ),
  Product(
    'Hero HollowKnight',
    "300\$",
    0,
    'asset/images/product3.jpg',
  ),
];
