import { Product } from "./Product";

export interface Sale {
    number: number;
    date: Date;
    saleItems: SaleItem[];
}

export interface SaleItem{
    product: Product;
    quantity: number;
    totalValue: number;
}