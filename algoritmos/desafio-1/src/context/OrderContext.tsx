import { createContext, useCallback, useContext, useMemo } from 'react'

import { v4 } from 'uuid'

import useLocalState from 'hooks/useLocalState'

import { CartType, OrderType } from 'types'

interface IContextProps {
  orders: OrderType[]
  addOrder: (cart: CartType) => void
}

interface IOrderProviderProps {
  children: React.ReactNode
}

export const ReactContext = createContext<IContextProps>({} as IContextProps)

export const OrderProvider: React.FC<IOrderProviderProps> = ({ children }) => {
  const [orders, setOrders] = useLocalState<OrderType[]>('desafio-1_orders', [])

  const addOrder = useCallback(
    (cart: CartType) => {
      setOrders([
        {
          ...cart,
          id: v4(),
          date: new Date().toString(),
        },
        ...orders,
      ])
    },
    [orders, setOrders],
  )

  return (
    <ReactContext.Provider
      value={useMemo(
        () => ({
          orders,
          addOrder,
        }),
        [orders, addOrder],
      )}
    >
      {children}
    </ReactContext.Provider>
  )
}

export const useOrder = (): IContextProps => {
  const context = useContext(ReactContext)

  if (!context) {
    // eslint-disable-next-line no-console
    console.error('useOrder must be within OrderProvider')
  }

  return context
}
