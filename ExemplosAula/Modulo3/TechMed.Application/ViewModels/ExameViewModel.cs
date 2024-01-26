namespace TechMed.Application.ViewModels;
public class ExameViewModel
{
    public int ExameId { get; set; }
    public string Nome { get; set; } = null!;
    public AtendimentoViewModel Atendimento { get; set; } = null!;
}
