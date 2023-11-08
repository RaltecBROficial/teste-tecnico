import React from 'react'

import ReactDOM from 'react-dom/client'

import { CartProvider } from 'context/CartContext'
import { OrderProvider } from 'context/OrderContext'

import App from './App'

import 'bootstrap/dist/css/bootstrap.min.css'

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <React.StrictMode>
    <CartProvider>
      <OrderProvider>
        <App />
      </OrderProvider>
    </CartProvider>
  </React.StrictMode>,
)
