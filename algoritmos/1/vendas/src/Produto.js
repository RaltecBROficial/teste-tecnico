import React, { useState } from 'react';
import './Produto.css'
const Produto = ({ name, value, imageUrl, codigo, adicionarAoCarrinho }) => {
    const [qtde, setQtde] = useState(0);
    const [total, setTotal] = useState(0);

    const handleAdicionar = () => {
        setQtde(qtde + 1);
    };

    const handleRemover = () => {
        if (qtde > 0) {
            setQtde(qtde - 1);
        }
    };

    const desconto = (quantidade) => {
        if (quantidade > 30) {
            return 0.8;
        } else if (quantidade > 20) {
            return 0.9;
        } else if (quantidade > 10) {
            return 0.95;
        }
        return 1;
    };

    const handleCompra = () => {
        if (qtde > 0) {
            const novoTotal = qtde * parseFloat(value);
            const novoProduto = {
                name,
                value,
                imageUrl,
                codigo,
                qtde,
                total: qtde * parseFloat(value),
                desc: novoTotal * desconto(qtde)
            };
            adicionarAoCarrinho(novoProduto);
            setTotal(novoProduto.total);
        }

    };

    return (
        <div className="box">
            <img src={'.\\images\\racao-pedigree-caes.jpg'} alt={''} />
            <h5 className='nome-produto'>{codigo} - {name}</h5>
            <p>Valor: R$ {value}</p>
            <div className='qtde-box'>
                <button className='buttonQtde-box' onClick={handleRemover}>-</button>
                <span>{qtde}</span>
                <button className='buttonQtde-box' onClick={handleAdicionar}>+</button>
            </div>
            <button className='button-box' onClick={handleCompra}>Comprar</button>
        </div>
    );
};

export default Produto;