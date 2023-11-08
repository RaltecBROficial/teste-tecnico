import { memo, useCallback } from 'react'

import { products } from '__MOCKS__/products'
import { Button, Container, Table } from 'react-bootstrap'

import { useCart } from 'context/CartContext'
import { useOrder } from 'context/OrderContext'

import { formatCurrency } from 'helpers'

const Home: React.FC = () => {
  const {
    cart,
    addProductToCart,
    updateProductQuantity,
    removeProductFromCart,
    clearCart,
  } = useCart()

  const { orders, addOrder } = useOrder()

  console.log({ orders })

  const handleConfirmOrder = useCallback(() => {
    addOrder(cart)
    clearCart()
  }, [addOrder, cart, clearCart])

  return (
    <Container className="py-5">
      <h2 className="mt-4">Lista de Produtos</h2>
      <Table striped bordered hover className="mb-4">
        <thead>
          <tr>
            <th>Código</th>
            <th>Produto</th>
            <th>Valor</th>
            <th>Ações</th>
          </tr>
        </thead>
        <tbody>
          {products.map((product) => (
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.name}</td>
              <td align="right">{formatCurrency(product.price)}</td>
              <td align="center">
                <Button onClick={() => addProductToCart(product)}>
                  Adicionar ao carrinho
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>

      <h2>Carrinho</h2>
      <Table striped bordered hover className="mb-4">
        <thead>
          <tr>
            <th>Código</th>
            <th>Produto</th>
            <th>Qtd</th>
            <th>Valor unitário</th>
            <th>Valor total</th>
            <th>Ações</th>
          </tr>
        </thead>
        <tbody>
          {cart.products.map((product) => (
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.name}</td>
              <td align="center">
                <Button
                  className="me-4"
                  onClick={() => updateProductQuantity(product.id, false)}
                >
                  -
                </Button>
                {product.quantity}
                <Button
                  className="ms-4"
                  onClick={() => updateProductQuantity(product.id)}
                >
                  +
                </Button>
              </td>
              <td align="right">{formatCurrency(product.price)}</td>
              <td align="right">
                {formatCurrency(product.quantity * product.price)}
              </td>
              <td align="center">
                <Button
                  variant="danger"
                  onClick={() => removeProductFromCart(product.id)}
                >
                  Remover
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
        <tfoot>
          <tr>
            <td align="right" colSpan={4}>
              Total:
            </td>
            <td align="center" colSpan={2}>
              {formatCurrency(Number(cart.total.toFixed(2)))}
            </td>
          </tr>
        </tfoot>
      </Table>

      <div className="text-end">
        <Button
          variant="success"
          type="button"
          onClick={handleConfirmOrder}
          className="mb-5"
        >
          Finalizar compra
        </Button>
      </div>

      <h2>Lista de compras</h2>
      <Table striped bordered hover className="mb-4">
        <thead>
          <tr>
            <th>Código</th>
            <th>Produtos</th>
            <th>Valor total</th>
            <th>Data</th>
          </tr>
        </thead>
        <tbody>
          {orders.map((order) => (
            <tr key={order.id}>
              <td>{order.id}</td>
              <td>
                <Table striped bordered hover>
                  <thead>
                    <tr>
                      <th>Nome</th>
                      <th>Qtd</th>
                      <th>Valor un.</th>
                    </tr>
                  </thead>
                  <tbody>
                    {order.products.map((product) => (
                      <tr key={product.id}>
                        <td>{product.name}</td>
                        <td align="right">{product.quantity}</td>
                        <td align="right">{formatCurrency(product.price)}</td>
                      </tr>
                    ))}
                  </tbody>
                </Table>
              </td>
              <td align="right">{formatCurrency(order.total)}</td>
              <td align="center">
                {new Date(order.date).toLocaleDateString()}
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </Container>
  )
}

export default memo(Home)
