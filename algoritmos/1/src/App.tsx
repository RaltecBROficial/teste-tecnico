import { useState } from "react";
import { Cart } from "./components/Cart/Cart";
import { Products } from "./components/Products/Products";
import { Item } from "./types/Cart";
import "./App.css";

function App() {
  const [cart, setCart] = useState<Item[]>([]);

  const calculateDiscount = (quantity: number) => {
    if (quantity > 30) return 20;
    if (quantity > 20) return 10;
    if (quantity > 10) return 5;
    return 0;
  };

  const calculateTotal = () => {
    return cart
      .reduce((total, item) => {
        const discount = calculateDiscount(item.quantity);
        const value = item.product.value * item.quantity;
        return total + (value - (value * discount) / 100);
      }, 0)
      .toFixed(2);
  };

  const calculateIndividual = (item: Item) => {
    const discount = calculateDiscount(item.quantity);
    const value = item.product.value * item.quantity;
    return (value - (value * discount) / 100).toFixed(2);
  };

  return (
    <>
      <Products cart={cart} setCart={setCart} />
      <Cart
        calculateDiscount={calculateDiscount}
        calculateTotal={calculateTotal}
        calculateIndividual={calculateIndividual}
        cart={cart}
      />
    </>
  );
}

export default App;
