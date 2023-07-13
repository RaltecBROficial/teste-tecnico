import { SaleItem } from '../../types/Sale'
import './index.css'
interface SaleCartProps {
    cart: SaleItem[]
    getTotal: () => string
    getDiscount: (quantity: number) => number
}

export const SaleCart = ({ cart, getTotal, getDiscount }: SaleCartProps) => {

    const handleMakeSale = () => {
        const total = getTotal()
        const items = cart.map((item) => `${item.quantity}x - ${item.product.name} por R$ ${item.product.unitValue} cada`)
        alert(`Itens comprados:\n${items.join('\n')} \nTotal pago: R$ ${total}`)
        window.location.reload()
    }

    return (
        <section className='section__saleCart'>
            <h2>Carrinho</h2>
            <table className='saleCart'>
                <thead>
                    <tr className='saleCart__row'>
                        <th>Produto</th>
                        <th>Quantidade</th>
                        <th>Preço</th>
                        <th>Desconto</th>
                    </tr>
                </thead>
                <tbody>
                    {cart.map((item) => (
                        <tr className='saleCart__row'>
                            <td>{item.product.name}</td>
                            <td>{item.quantity}</td>
                            <td>R$ {item.product.unitValue.toFixed(2)}</td>
                            <td>{getDiscount(item.quantity).toFixed(2)}%</td>
                        </tr>
                    ))}
                    <tr className='saleCart__row'>
                        <td colSpan={2}>Total</td>
                        <td>R$ {getTotal()}</td>
                    </tr>
                </tbody>
            </table>
            <div className='section__saleCart--actions'>
                <button className='danger' onClick={() => window.location.reload()}>Limpar Carrinho</button>
                <button onClick={handleMakeSale}>Finalizar</button>
            </div>
        </section>
    )
}
