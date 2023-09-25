using SistemaComercial.API.Entities;
using SistemaComercial.API.Interfaces.Settings.ValidationSettings;

namespace SistemaComercial.API.Settings.ValidationSettings;

public sealed class ProdutoValidation : IProdutoValidation
{
    public ValidationResult IsValid(Produto produto)
    {
        var validationResult = new ValidationResult() 
        {
            Errors = new List<string>(),
            IsValid = true
        };

        var nomeLength = produto.Nome.Length;

        if(nomeLength < 1 || nomeLength > 50)
        {
            validationResult.Errors.Add("Nome com tamanho inválido.");
            validationResult.IsValid = false;
        }

        if(produto.ValorUnitario < 0)
        {
            validationResult.Errors.Add("Valor do produto precisa ser menor que 0.");
            validationResult.IsValid = false;
        }

        return validationResult;
    }
}
