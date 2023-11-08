import {
  createContext,
  useCallback,
  useContext,
  useMemo,
  useState,
} from 'react'

import { CartProductType, CartType, ProductType } from 'types'

interface IContextProps {
  cart: CartType
  addProductToCart: (product: ProductType) => void
  updateProductQuantity: (productId: string, add?: boolean) => void
  removeProductFromCart: (productId: string) => void
  clearCart: () => void
}

interface ICartProviderProps {
  children: React.ReactNode
}

export const ReactContext = createContext<IContextProps>({} as IContextProps)

const calculateDiscount = (quantity: number): number => {
  if (quantity > 30) return 20
  if (quantity > 20) return 10
  if (quantity > 10) return 5

  return 0
}

const calculateTotalValue = (products: CartProductType[]): number => {
  const totalWithoutDiscount = products.reduce(
    (acc, p) => acc + p.price * p.quantity,
    0,
  )

  return (
    totalWithoutDiscount -
    (totalWithoutDiscount *
      calculateDiscount(products.reduce((acc, p) => acc + p.quantity, 0))) /
      100
  )
}

export const CartProvider: React.FC<ICartProviderProps> = ({ children }) => {
  const [cart, setCart] = useState<CartType>({ products: [], total: 0 })

  const addProductToCart = useCallback(
    (productToAdd: ProductType) => {
      const product = cart.products.find((p) => p.id === productToAdd.id)

      let { products } = cart

      if (product) {
        products = cart.products.map((p) =>
          p.id === productToAdd.id ? { ...p, quantity: p.quantity + 1 } : p,
        )
      } else {
        products.push({ ...productToAdd, quantity: 1 })
      }

      setCart({ products, total: calculateTotalValue(products) })
    },
    [cart],
  )

  const updateProductQuantity = useCallback(
    (productId: string, add = true) => {
      let { products } = cart

      products = products
        .map((p) =>
          p.id === productId
            ? { ...p, quantity: p.quantity + (add ? 1 : -1) }
            : p,
        )
        .filter((p) => p.quantity > 0)

      setCart({ products, total: calculateTotalValue(products) })
    },
    [cart],
  )

  const removeProductFromCart = useCallback(
    (productId: string) => {
      let { products } = cart

      products = products.filter((p) => p.id !== productId)

      setCart({
        products,
        total: calculateTotalValue(products),
      })
    },
    [cart],
  )

  const clearCart = useCallback(
    () =>
      setCart({
        products: [],
        total: 0,
      }),
    [],
  )

  return (
    <ReactContext.Provider
      value={useMemo(
        () => ({
          cart,
          addProductToCart,
          updateProductQuantity,
          removeProductFromCart,
          clearCart,
        }),
        [
          cart,
          addProductToCart,
          updateProductQuantity,
          removeProductFromCart,
          clearCart,
        ],
      )}
    >
      {children}
    </ReactContext.Provider>
  )
}

export const useCart = (): IContextProps => {
  const context = useContext(ReactContext)

  if (!context) {
    // eslint-disable-next-line no-console
    console.error('useCartHook must be within CartProvider')
  }

  return context
}
