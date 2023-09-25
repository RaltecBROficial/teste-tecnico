namespace SistemaComercial.API.Settings.ValidationSettings;

public sealed class ValidationResult
{
    public List<string> Errors { get; set; }
    public bool IsValid { get; set; }
}
