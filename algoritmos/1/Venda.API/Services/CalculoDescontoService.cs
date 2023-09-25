using SistemaComercial.API.Interfaces.Services;

namespace SistemaComercial.API.Services;
public sealed class CalculoDescontoService : ICalculoDescontoService
{
    /* Desconto por quantidade
    acima de 10 - 5%
    acima de 20 - 10%
    acima de 30 - 20% */

    public decimal CalcularDesconto(int quantidade)
    {
        decimal desconto = 0;

        if (quantidade > 30)
        {
            desconto = 20; 
        }
        else if (quantidade > 20)
        {
            desconto = 10; 
        }
        else if (quantidade > 10)
        {
            desconto = 5; 
        }

        return desconto;
    }
}
