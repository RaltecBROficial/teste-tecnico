using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialSystem.Shared.DTOs
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }

        [Required(ErrorMessage = "É necessario selecionar um produto!")]
        [Range(1, int.MaxValue, ErrorMessage = "É necessario selecionar um produto!")]
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public string ProductVlrUnit { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessario informar a quantidade!")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "A quantidade deve ser um número inteiro.")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public string QtdProduct { get; set; } = string.Empty;

        public decimal Subtotal { get; set; }
    }
}