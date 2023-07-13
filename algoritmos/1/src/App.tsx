import { useState } from 'react'
import './App.css'
import { SaleCart } from './components/SaleCart/SaleCart'
import { SaleForm } from './components/SaleForm/SaleForm'
import { SaleItem } from './types/Sale'

function App() {

  const [cart, setCart] = useState<SaleItem[]>([])

  const getDiscount = (quantity: number) => {
    if (quantity > 10 && quantity <= 20) return 5
    else if (quantity > 20 && quantity <= 30) return 10
    else if (quantity > 30) return 20
    else return 0
}

const getTotal = () => {
    let total = 0
    cart.forEach((item) => {
        const discount = getDiscount(item.quantity)
        const value = item.product.unitValue * item.quantity
        total += value - (value * discount / 100)
    })
    return total.toFixed(2)
}
  return (
    <>
      <SaleForm getDiscount={getDiscount} cart={cart} setCart={setCart} />
      <SaleCart getDiscount={getDiscount} getTotal={getTotal} cart={cart} />
    </>
  )
}

export default App
