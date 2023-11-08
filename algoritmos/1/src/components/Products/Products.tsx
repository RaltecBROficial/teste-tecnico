import React from "react";
import { Item } from "../../types/Cart";
import { products } from "../../data/products";
import "./Products.css";

interface ProductsProps {
  cart: Item[];
  setCart: React.Dispatch<React.SetStateAction<Item[]>>;
}

export const Products = ({ cart, setCart }: ProductsProps) => {
  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement>,
    code: string
  ) => {
    const quantity = e.target.value;
    if (!quantity) return;

    const selectedCode = code;
    if (!selectedCode) return;

    const selectedProduct = products.find(
      (product) => product.code === parseInt(selectedCode)
    );

    if (!selectedProduct) return;

    const itemAlreadyExists = cart.find(
      (item) => item.product.code === selectedProduct.code
    );

    const updatedItem = {
      product: selectedProduct,
      quantity: parseInt(quantity),
    } as Item;

    if (quantity === "0") {
      setCart(
        cart.filter((item) => item.product.code.toString() !== selectedCode)
      );
    }

    if (itemAlreadyExists) {
      setCart((cart) =>
        cart.map((item) =>
          item.product.code === selectedProduct.code ? updatedItem : item
        )
      );
    } else {
      setCart((cart) => [...cart, updatedItem]);
    }
  };

  return (
    <form>
      <h2>Produtos</h2>
      <div className="products">
        {products.map((product) => (
          <>
            <span className="product" key={`${product.code}`}>
              <b>{product.name}</b>
              <span
                style={{
                  display: "flex",
                  justifyContent: "space-between",
                  alignItems: "center",
                }}>
                R$ {product.value.toFixed(2)}
                <input
                  onChange={(e) => handleChange(e, product.code.toString())}
                  type="number"
                  defaultValue={0}
                  min={0}
                  max={99}
                  name="quantity"
                  id="quantity"
                />
              </span>
            </span>
          </>
        ))}
      </div>
    </form>
  );
};
