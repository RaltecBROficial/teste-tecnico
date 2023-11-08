import { Product } from "./Product";

export interface Cart {
  number: number;
  date: Date;
  items: Item[];
}

export interface Item {
  product: Product;
  quantity: number;
  value: number;
}
