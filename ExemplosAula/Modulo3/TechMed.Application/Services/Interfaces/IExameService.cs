using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.Application.Services.Interfaces;
public interface IExameService
{
    public List<ExameViewModel> GetAll();
    public List<ExameViewModel> GetByAtendimentoId(int atendimentoId);
    public int Create(NewExameInputModel exame);
}
