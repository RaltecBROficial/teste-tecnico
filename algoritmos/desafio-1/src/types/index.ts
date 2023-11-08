export type ProductType = {
  id: string
  name: string
  price: number
}

export type CartProductType = ProductType & {
  quantity: number
}

export type CartType = {
  products: CartProductType[]
  total: number
}

export type OrderType = {
  id: string
  products: CartProductType[]
  total: number
  date: string
}
