using SistemaComercial.API.Entities;
using SistemaComercial.API.Settings.ValidationSettings;

namespace SistemaComercial.API.Interfaces.Settings.ValidationSettings;

public interface IProdutoValidation
{
    public ValidationResult IsValid(Produto produto);
}
