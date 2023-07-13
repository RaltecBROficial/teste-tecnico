import React, { useState } from 'react';
import Produto from './Produto';
import './App.css'

const ProductForm = ({ onAddProduct }) => {

  const [carrinho, setCarrinho] = useState([]);
  const [numeroVenda, setNumeroVenda] = useState(0);
  const [dataHora, setDataHora] = useState('');

  const adicionarAoCarrinho = (produto) => {
    setCarrinho([...carrinho, produto]);
  };

  const removerDoCarrinho = (index) => {
    const novoCarrinho = [...carrinho];
    novoCarrinho.splice(index, 1);
    setCarrinho(novoCarrinho);
  };

  const calcularTotalGeral = () => {
    const totalGeral = carrinho.reduce((acumulador, produto) => {
      return acumulador + produto.desc;
    }, 0);
    return totalGeral;
  };

  const fecharCarrinho = () => {
    const venda = {
      numeroVenda: numeroVenda + 1,
      dataHora: new Date().toLocaleString(),
      itensVendidos: carrinho.map((produto) => ({
        produto: produto.name,
        qtde: produto.qtde,
        vlrTotal: produto.total,
      })),
    };
    onAddProduct(venda);
    setCarrinho([]);
    setNumeroVenda(numeroVenda + 1);
    setDataHora('');
  };

  return (
    <div className="container">
      <div className='row'>
        <div className="catalogo">
          <Produto
            codigo={"0001"}
            name="Ração Pedigree Cães Adultos Raças Médias E Grandes Carne, Frango E Cereais 2,7 Kg"
            value={56.90}
            imageUrl="./images/racao-pedigree-caes.jpg"
            adicionarAoCarrinho={adicionarAoCarrinho}
          />
          <Produto
            codigo={"0002"}
            name="Ração Whiskas Para Gatos Filhotes: Sabor Carne E Leite - 500g"
            value={19.95}
            imageUrl="./images/racao-whiskas-gatos.jpg"
            adicionarAoCarrinho={adicionarAoCarrinho}
          />
          <Produto
            codigo={"0003"}
            name="Ração Nutrópica Calopsita Com Frutas 300g"
            value={35.90}
            imageUrl="./images/racao-nutropica-calopsitas.jpg"
            adicionarAoCarrinho={adicionarAoCarrinho}
          />
          <Produto
            codigo={"0004"}
            name="Ração Dr. Aquário Betta Bits 4g"
            value={6.90}
            imageUrl="./images/racao-draquario-betas.jpg"
            adicionarAoCarrinho={adicionarAoCarrinho}
          />
        </div>
        <div className='carrinho'>
          <h2>Carrinho:</h2>
          {
            carrinho.map((produto, index) => (
              <div key={index}>
                <p className='carrinho-info'>{produto.name}</p>
                <p className='carrinho-info'>{produto.qtde}x R${produto.value}</p>
                <p className='carrinho-info'>Total: R$ {produto.total.toFixed(2)}</p>
                <p className='carrinho-info'>Total com desconto: R$ {produto.desc.toFixed(2)}</p>
                <button onClick={() => removerDoCarrinho(index)}>Remover</button>
                <hr />
              </div>
            ))}
          <div>
            <h5>Total da compra: R${calcularTotalGeral().toFixed(2)}</h5>
            <button className='carrinho-button' onClick={fecharCarrinho}>Fechar o carrinho</button>
          </div>
        </div>
      </div>
    </div>
  );
};

const App = () => {
  const [vendas, setVendas] = useState([]);

  const handleAddProduct = (venda) => {
    setVendas([...vendas, venda]);
  };

  return (
    <div className='container'>
      <ProductForm onAddProduct={handleAddProduct} />
      {/* Mostrar lista de vendas */}
      <div className='lista-venda'>
        <h2>Lista de Vendas:</h2>
        {vendas.map((venda, index) => (
          <div key={index}>
            <div className=''>
              <h5>Número da Venda: {venda.numeroVenda}</h5>
              <h5>Data e Hora: {venda.dataHora}</h5>
            </div>
            <h5>Itens Vendidos:</h5>
            {venda.itensVendidos.map((item, itemIndex) => (
              <div key={itemIndex}>
                <p className='carrinho-info'>Produto: {item.produto}</p>
                <p className='carrinho-info'>Quantidade: {item.qtde}</p>
                <p className='carrinho-info'>Valor Total de Venda: R$ {item.vlrTotal.toFixed(2)}</p>
              </div>
            ))}
            <hr />
          </div>
        ))}
      </div>
    </div>
  );
};

export default App;
