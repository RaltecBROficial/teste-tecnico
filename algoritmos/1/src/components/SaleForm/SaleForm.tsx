import React, { useEffect, useRef } from 'react'
import { SaleItem } from '../../types/Sale'
import { products } from '../../data/products'
import './index.css'

interface SaleFormProps {
    cart: SaleItem[]
    setCart: React.Dispatch<React.SetStateAction<SaleItem[]>>
    getDiscount: (quantity: number) => number
}

export const SaleForm = ({ cart, setCart, getDiscount }: SaleFormProps) => {
    const productNameRef = useRef<HTMLSelectElement>(null)
    const productQuantityRef = useRef<HTMLInputElement>(null)
    const productValueRef = useRef<HTMLInputElement>(null)
    const totalSaleRef = useRef<HTMLInputElement>(null)

    const renderProducts = () => products.map((product) => (
        <option key={product.code.toString() + product.name} value={product.code}>{product.name}</option>
    ))

    useEffect(() => {
        const productCode = productNameRef.current?.value
        if (!productCode) return
        const product = products.find((product) => product.code === parseInt(productCode))
        if (!product) return
        productValueRef.current!.value = product.unitValue.toFixed(2)
    }, [productNameRef.current?.value])
    
    const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
        event.preventDefault()
        const productCode = productNameRef.current?.value
        const productQuantity = productQuantityRef.current?.value
        if (!productCode || !productQuantity) return
        const product = products.find((product) => product.code === parseInt(productCode))
        if (!product) return
        if (cart.find((item) => item.product.code === product.code))
            setCart(cart => cart.map((item) => {
                if (item.product.code === product.code) {
                    return { product, quantity: parseInt(productQuantity) } as SaleItem
                }
                return item
            }))
        else
            setCart(cart => [...cart, { product, quantity: parseInt(productQuantity) } as SaleItem])
    }

    const handleSelectProductChange = () => {
        const productCode = productNameRef.current?.value
        if (!productCode) return
        const product = products.find((product) => product.code === parseInt(productCode))
        if (!product) return
        productValueRef.current!.value = product.unitValue.toFixed(2)
    }

    const handleProductQuantityChange = () => {
        const productQuantity = productQuantityRef.current?.value
        if (!productQuantity) return
        const productCode = productNameRef.current?.value
        if (!productCode) return
        const product = products.find((product) => product.code === parseInt(productCode))
        if (!product) return
        const total = (product.unitValue * parseInt(productQuantity))
        totalSaleRef.current!.value = "R$ " + (total - (total * getDiscount(parseInt(productQuantity)) / 100)).toFixed(2)
    }
    return (

        <form className='form' onSubmit={handleSubmit}>
            <h2>Formulário</h2>
            <label htmlFor="productName">
                Selecione um produto
                <select onChange={handleSelectProductChange} ref={productNameRef} name="productName" id="productName">
                    {renderProducts()}
                </select>
            </label>
            <label htmlFor="productName">
                Valor unitário
                <input ref={productValueRef} type="text" name="productValue" id="productValue" disabled />
            </label>
            <label htmlFor="productQuantity">
                Quantidade
                <input onChange={handleProductQuantityChange} ref={productQuantityRef} type="number" defaultValue={0} min={0} max={99} name="productQuantity" id="productQuantity" />
            </label>
            <label htmlFor="totalSale">
                SubTotal
                <input ref={totalSaleRef} type="text" name="totalSale" id="totalSale" disabled />
            </label>
            <button type="submit">Adicionar</button>
        </form >

    )
}
