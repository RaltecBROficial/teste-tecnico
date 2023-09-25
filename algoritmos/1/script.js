let productDatabase = [
    { code: 1, name: "Produto A", unitPrice: 10, discount: { 10: 5, 20: 10, 30: 20 } },
    { code: 2, name: "Produto B", unitPrice: 15, discount: { 10: 5, 20: 10, 30: 20 } },
    { code: 3, name: "Produto C", unitPrice: 20, discount: { 10: 5, 20: 10, 30: 20 } },
];

let cart = [];
let saleNumber = 1;

function addProduct() {
    const productCode = parseInt(document.getElementById("productCode").value);
    const productName = document.getElementById("productName").value;
    const unitPrice = parseFloat(document.getElementById("unitPrice").value);
    const quantity = parseInt(document.getElementById("quantity").value);

    const product = productDatabase.find(p => p.code === productCode);

    if (!product || isNaN(quantity) || quantity <= 0) {
        alert("Produto inválido ou quantidade inválida.");
        return;
    }

    let discount = 0;
    if (quantity >= 30) {
        discount = product.discount[30];
    } else if (quantity >= 20) {
        discount = product.discount[20];
    } else if (quantity >= 10) {
        discount = product.discount[10];
    }

    const total = unitPrice * quantity * (1 - discount / 100);

    const item = {
        code: product.code,
        name: product.name,
        quantity: quantity,
        unitPrice: unitPrice,
        discount: discount,
        total: total
    };

    cart.push(item);

    updateCartTable();

    document.getElementById("productCode").value = "";
    document.getElementById("productName").value = "";
    document.getElementById("unitPrice").value = "";
    document.getElementById("quantity").value = "";
}

function updateCartTable() {
    const cartTable = document.getElementById("cart");
    cartTable.innerHTML = "";
    
    cart.forEach(item => {
        const row = cartTable.insertRow();
        row.insertCell(0).innerText = item.code;
        row.insertCell(1).innerText = item.name;
        row.insertCell(2).innerText = item.quantity;
        row.insertCell(3).innerText = item.unitPrice.toFixed(2);
        row.insertCell(4).innerText = item.discount + "%";
        row.insertCell(5).innerText = item.total.toFixed(2);
    });
}

function checkout() {
    if (cart.length === 0) {
        alert("O carrinho está vazio. Adicione produtos antes de finalizar a compra.");
        return;
    }

    const dateTime = new Date().toLocaleString();

    const sale = {
        saleNumber: saleNumber,
        dateTime: dateTime,
        items: cart
    };

    const salesHistory = document.getElementById("salesHistory");
    const saleItem = document.createElement("li");
    saleItem.innerText = `Venda #${sale.saleNumber} - ${sale.dateTime}`;
    salesHistory.appendChild(saleItem);

    cart = [];
    updateCartTable();

    saleNumber++;

    alert("Compra finalizada com sucesso!");
}
