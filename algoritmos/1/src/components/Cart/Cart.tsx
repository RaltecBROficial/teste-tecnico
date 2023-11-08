import { Modal } from "@mui/material";
import { Item } from "../../types/Cart";
import "./Cart.css";
import { useState } from "react";
import CloseIcon from "@mui/icons-material/Close";

interface CartProps {
  cart: Item[];
  calculateTotal: () => string;
  calculateDiscount: (quantity: number) => number;
  calculateIndividual: (item: Item) => string;
}

export const Cart = ({
  cart,
  calculateTotal,
  calculateDiscount,
  calculateIndividual,
}: CartProps) => {
  const [open, setOpen] = useState(false);

  const ellipsisString = (str: string) => {
    return str.length > 14 ? str.substring(0, 14 - 3) + "..." : str;
  };

  return (
    <section>
      <h2>Carrinho</h2>
      <table>
        <tbody>
          <tr>
            <td>
              <b>Produto</b>
            </td>
            <td>
              <b>Quantidade</b>
            </td>
            <td>
              <b>Vl. Unitário</b>
            </td>
            <td>
              <b>Preço</b>
            </td>
            <td>
              <b>Desconto</b>
            </td>
          </tr>
          {cart.map((item, index) => (
            <tr key={index}>
              <td>{ellipsisString(item.product.name)}</td>
              <td>{item.quantity}</td>
              <td>R$ {item.product.value.toFixed(2)}</td>
              <td>R$ {calculateIndividual(item)}</td>
              <td>{calculateDiscount(item.quantity).toFixed(2)}%</td>
            </tr>
          ))}
          <tr>
            <td colSpan={2}>Total</td>
            <td>R$ {calculateTotal()}</td>
          </tr>
        </tbody>
      </table>
      <div className="actions">
        <button disabled={cart.length === 0} onClick={() => setOpen(true)}>
          Finalizar Compra
        </button>
        <button className="cancel" onClick={() => window.location.reload()}>
          Esvaziar Carrinho
        </button>
      </div>
      <Modal
        open={open}
        onClose={() => {}}
        style={{
          display: "flex",
          justifySelf: "center",
          alignSelf: "center",
          fontFamily: "system-ui",
        }}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description">
        <div
          style={{
            padding: "24px 16px",
            width: "50%",
            margin: "auto",
            borderRadius: "8px",
            backgroundColor: "#fff",
          }}>
          <span
            style={{
              justifyContent: "space-between",
              display: "flex",
              flexDirection: "row",
              marginBottom: "16px",
            }}>
            <h2 style={{ margin: "0" }}>Compra realizada com sucesso!</h2>
            <CloseIcon
              style={{ cursor: "pointer" }}
              onClick={() => {
                window.location.reload();
              }}
            />
          </span>
          <span>
            {cart.map((item) => (
              <>
                {`${item.quantity} ${
                  item.product.name
                } por R$ ${item.product.value.toFixed(2)} a unidade`}
                <br />
              </>
            ))}
          </span>
        </div>
      </Modal>
    </section>
  );
};
