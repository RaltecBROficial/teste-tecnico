using System.ComponentModel.DataAnnotations;

namespace CommercialSystem.Shared.DTOs
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessario fornecer o nome!")]
        [StringLength(40, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "É necessario fornecer o preço unitario!")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "O preço deve ser um número decimal com até 2 casas decimais.")]
        public string UnitPrice { get; set; } = string.Empty;
    }
}
